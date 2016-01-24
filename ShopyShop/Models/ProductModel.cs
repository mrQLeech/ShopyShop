namespace ShopyShop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModel1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AccessPermissions> AccessPermissions { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<LocalUsers> LocalUsers { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<ProductImages> ProductImages { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsSection> ProductsSection { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UserPermissions> UserPermissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessPermissions>()
                .HasMany(e => e.UserPermissions)
                .WithRequired(e => e.AccessPermissions)
                .HasForeignKey(e => e.PermissionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Discount>()
                .Property(e => e.DiscountValue)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Discount>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Discount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LocalUsers>()
                .HasMany(e => e.UserPermissions)
                .WithRequired(e => e.LocalUsers)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Manufacturer)
                .HasForeignKey(e => e.MakerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(20, 4);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ProductImages)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductsSection>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductsSection)
                .HasForeignKey(e => e.SectionId)
                .WillCascadeOnDelete(false);
        }
    }
}
