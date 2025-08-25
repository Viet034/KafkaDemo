using connectOracleDBTest.Data.EntityConfig;
using connectOracleDBTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace connectOracleDBTest.Data;

public class ApplicationDbContext : DbContext
{
    private readonly DbContextOptions<ApplicationDbContext> _option;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

        _option = options;
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("VIETHADEV");
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
    }
}







