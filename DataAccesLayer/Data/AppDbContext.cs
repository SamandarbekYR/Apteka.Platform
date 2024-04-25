using Domian.Entities.Branchs;
using Domian.Entities.Categories;
using Domian.Entities.Products;
using Domian.Entities.Receipts;
using Domian.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.Data;

public class AppDbContext : DbContext
{
    public DbSet<UserRole> UserRole { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductItem> ProductItems { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<ReceiptItems> ReceiptsItems { get; set;}

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(u => u.Role)
                  .WithMany(ur => ur.User)
                  .HasForeignKey(u => u.RoleId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasOne(p => p.Category)
                  .WithMany(ur => ur.Products)
                  .HasForeignKey(e => e.CategoryId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ProductItem>(entity =>
        {
            entity.HasOne(p => p.Product)
                  .WithMany(e => e.ProductItems)
                  .HasForeignKey(e => e.ProductId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(p => p.Branch)
                  .WithMany(e => e.ProductItems)
                  .HasForeignKey(e =>e.BranchId)
                  .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Receipt>(entity =>
        {
            entity.HasOne(e => e.Branch)
                  .WithMany(e => e.Receipts)
                  .HasForeignKey(e => e.BranchId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ReceiptItems>(entity =>
        {
            entity.HasOne(e => e.Receipt)
                  .WithMany(e => e.ReceiptItems)
                  .HasForeignKey (e => e.ReceiptId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(e => e.Product)
                  .WithMany(e => e.ReceiptItems)
                  .HasForeignKey(e => e.ProductId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        base.OnModelCreating(modelBuilder);
    }
}
