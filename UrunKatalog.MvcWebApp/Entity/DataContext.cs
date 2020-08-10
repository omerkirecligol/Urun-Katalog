using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UrunKatalog.MvcWebApp.Entity
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }


        
    }
}