using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using EFObjects.Tables;

namespace EFObjects.Context
{
    /// <summary>
    /// Singleton for database
    /// </summary>
    public partial class DBContext : DbContext
    {
        public static DBContext _context = null;

        private DBContext()
        {
            _context = this;
        }

        public static DBContext GetInstance()
        {
            return _context ?? new DBContext();
        }

        public DbSet<Biere> Biere { get; set; }
        public DbSet<Microbrasserie> Microbrasserie { get; set; }
        public DbSet<Houblon> Houblon { get; set; }
        public DbSet<Region> Regions{ get; set; }
        public DbSet<TypeBiere> TypeBiere { get; set; }
        public DbSet<Volume> Volumes { get; set; }
    }
}