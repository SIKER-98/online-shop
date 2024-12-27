using Microsoft.EntityFrameworkCore;

namespace online_shop.Data;

public class OrderContext : DbContext
{
    public System.Data.Entity.DbSet<Address> Addresses { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderPosition> OrderPositions { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Store> Stores { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("MyDb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // TODO: zapełnić bazę danymi
    }
}