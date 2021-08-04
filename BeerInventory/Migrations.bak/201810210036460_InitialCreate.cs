namespace BeerInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bieres",
                c => new
                    {
                        id_biere = c.Int(nullable: false, identity: true),
                        nom = c.String(),
                        volume = c.Double(nullable: false),
                        appreciation = c.String(),
                        microbrasserie_id_microbrasserie = c.Int(),
                        type_id_type = c.Int(),
                    })
                .PrimaryKey(t => t.id_biere)
                .ForeignKey("dbo.Microbrasseries", t => t.microbrasserie_id_microbrasserie)
                .ForeignKey("dbo.Types", t => t.type_id_type)
                .Index(t => t.microbrasserie_id_microbrasserie)
                .Index(t => t.type_id_type);
            
            CreateTable(
                "dbo.Houblons",
                c => new
                    {
                        id_houblon = c.Int(nullable: false, identity: true),
                        nom = c.String(),
                    })
                .PrimaryKey(t => t.id_houblon);
            
            CreateTable(
                "dbo.Microbrasseries",
                c => new
                    {
                        id_microbrasserie = c.Int(nullable: false, identity: true),
                        nom = c.String(),
                        region_id_region = c.Int(),
                    })
                .PrimaryKey(t => t.id_microbrasserie)
                .ForeignKey("dbo.Regions", t => t.region_id_region)
                .Index(t => t.region_id_region);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        id_region = c.Int(nullable: false, identity: true),
                        nom = c.String(),
                    })
                .PrimaryKey(t => t.id_region);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        id_type = c.Int(nullable: false, identity: true),
                        type = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id_type);
            
            CreateTable(
                "dbo.HoublonBieres",
                c => new
                    {
                        Houblon_id_houblon = c.Int(nullable: false),
                        Biere_id_biere = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Houblon_id_houblon, t.Biere_id_biere })
                .ForeignKey("dbo.Houblons", t => t.Houblon_id_houblon, cascadeDelete: true)
                .ForeignKey("dbo.Bieres", t => t.Biere_id_biere, cascadeDelete: true)
                .Index(t => t.Houblon_id_houblon)
                .Index(t => t.Biere_id_biere);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bieres", "type_id_type", "dbo.Types");
            DropForeignKey("dbo.Microbrasseries", "region_id_region", "dbo.Regions");
            DropForeignKey("dbo.Bieres", "microbrasserie_id_microbrasserie", "dbo.Microbrasseries");
            DropForeignKey("dbo.HoublonBieres", "Biere_id_biere", "dbo.Bieres");
            DropForeignKey("dbo.HoublonBieres", "Houblon_id_houblon", "dbo.Houblons");
            DropIndex("dbo.HoublonBieres", new[] { "Biere_id_biere" });
            DropIndex("dbo.HoublonBieres", new[] { "Houblon_id_houblon" });
            DropIndex("dbo.Microbrasseries", new[] { "region_id_region" });
            DropIndex("dbo.Bieres", new[] { "type_id_type" });
            DropIndex("dbo.Bieres", new[] { "microbrasserie_id_microbrasserie" });
            DropTable("dbo.HoublonBieres");
            DropTable("dbo.Types");
            DropTable("dbo.Regions");
            DropTable("dbo.Microbrasseries");
            DropTable("dbo.Houblons");
            DropTable("dbo.Bieres");
        }
    }
}
