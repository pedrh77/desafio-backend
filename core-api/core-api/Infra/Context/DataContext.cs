using core_api.Features.Products.Models;
using Microsoft.EntityFrameworkCore;

namespace core_api.Infra.Context;


public class DataContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Product> Products { get; set; }
}