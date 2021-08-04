using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using EFObjects.Tables;

namespace EFObjects.Context
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<DBContext>
    {
        public override void InitializeDatabase(DBContext context)
        {
            //context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "ALTER DATABASE [" + context.Database.Connection.Database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            //SqlConnection.ClearAllPools();
            base.InitializeDatabase(context);
        }

        protected override void Seed(DBContext context)
        {
            string script = File.ReadAllText(@"C:\Users\David\Documents\Visual Studio 2015\Projects\BeerInventory\BeerInventory\scripts\SeedData.sql");
            context.Database.ExecuteSqlCommand(script);
        }
    }
}