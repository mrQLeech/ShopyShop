using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShopyShop.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext()
            : base("ProductContext")
        {
            //Database.SetInitializer<ProductContext>(new CreateDatabaseIfNotExists<ProductContext>());
            var my_strategy =
                new DropCreateDatabaseIfModelChanges<ProductContext>();
            Database.SetInitializer(my_strategy);
        }

    


        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Makers { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Discount> Discounts { get; set; }      
      /*  public DbSet<LocalUser> Users { get; set; }
        public DbSet<AccessGroup> Groups { get; set; }*/

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

            /*modelBuilder.Entity<Product>()
                .HasMany(s => s.Images)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(c => c.Products)
                .WithRequired(e => e.Maker)
                .HasForeignKey(e => e.MakerId);

          /*  modelBuilder.Entity<Discount>()
                .HasMany(s => s.Products)
                .WithRequired(e => e.Discount)
                .HasForeignKey(e => e.DiscountId);

            modelBuilder.Entity<LocalUser>()
                 .HasMany<AccessGroup>(s => s.AccessGroups)
                 .WithMany(c => c.Users)
                 .Map(cs =>
                 {
                     cs.MapLeftKey("LocalUserRefId");
                     cs.MapRightKey("AccessGroupRefId");
                     cs.ToTable("UserGroup");
                 });*/

        }
    }

    
}