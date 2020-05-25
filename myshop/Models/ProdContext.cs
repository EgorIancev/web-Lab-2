using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace myshop.Models
{
    public class ProdContext : DbContext
    {
        public DbSet<prod> prod { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}