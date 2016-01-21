using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopyShop.Models
{
    public class ProductContexts:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Makers { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Product> Products { get; set; }
    }

    
}