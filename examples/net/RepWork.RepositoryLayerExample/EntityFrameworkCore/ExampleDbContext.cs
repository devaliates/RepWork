using Microsoft.EntityFrameworkCore;

using RepWork.RepositoryLayerExample.Entities;

namespace RepWork.RepositoryLayerExample.EntityFrameworkCore;

public class ExampleDbContext
    : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }

    public ExampleDbContext(DbContextOptions<ExampleDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserProduct>()
        .HasKey(up => new { up.UserId, up.ProductId });

        modelBuilder.Entity<UserProduct>()
            .HasOne(up => up.User)
            .WithMany(u => u.UserProducts)
            .HasForeignKey(up => up.UserId);

        modelBuilder.Entity<UserProduct>()
            .HasOne(up => up.Product)
            .WithMany(p => p.UserProducts)
            .HasForeignKey(up => up.ProductId);

        base.OnModelCreating(modelBuilder);
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder
    //        .UseNpgsql(@"User ID=deneme; Password=deneme; Server=localhost; Port=5432; Database=ExampleDbTest; Integrated Security=true; Pooling=true;");
    //}
}