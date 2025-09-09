using Microsoft.EntityFrameworkCore;
using OnlineShop.Models.Entities;

namespace OnlineShop.Data.DAO
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<VendorEntity> Vendors { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CartEntity> Carts { get; set; }
        public DbSet<CartItemEntity> CartItems { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderItemEntity> OrderItems { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Category - Product (1:N)
            modelBuilder.Entity<CategoryEntity>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Vendor - Product (1:N, VendorId nullable)
            modelBuilder.Entity<VendorEntity>()
                .HasMany(v => v.Products)
                .WithOne(p => p.Vendor)
                .HasForeignKey(p => p.VendorId)
                .OnDelete(DeleteBehavior.SetNull);

            // User - Cart (1:1)
            modelBuilder.Entity<UserEntity>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<CartEntity>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cart - CartItem (1:N)
            modelBuilder.Entity<CartEntity>()
                .HasMany(c => c.Carts)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            // Product - CartItem (1:N)
            modelBuilder.Entity<ProductEntity>()
                .HasMany(p => p.CartItems)
                .WithOne(ci => ci.Product)
                .HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // User - Order (1:N)
            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Order - OrderItem (1:N)
            modelBuilder.Entity<OrderEntity>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Product - OrderItem (1:N)
            modelBuilder.Entity<ProductEntity>()
                .HasMany(p => p.OrderItems)
                .WithOne(oi => oi.Product)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // Order - Payment (1:1)
            modelBuilder.Entity<OrderEntity>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<PaymentEntity>(p => p.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Table names (optional, for clarity)
            modelBuilder.Entity<CategoryEntity>().ToTable("Category");
            modelBuilder.Entity<ProductEntity>().ToTable("Product");
            modelBuilder.Entity<VendorEntity>().ToTable("Vendor");
            modelBuilder.Entity<UserEntity>().ToTable("User");
            modelBuilder.Entity<CartEntity>().ToTable("Cart");
            modelBuilder.Entity<CartItemEntity>().ToTable("CartItem");
            modelBuilder.Entity<OrderEntity>().ToTable("Order");
            modelBuilder.Entity<OrderItemEntity>().ToTable("OrderItem");
            modelBuilder.Entity<PaymentEntity>().ToTable("Payment");
        }
    }
}
