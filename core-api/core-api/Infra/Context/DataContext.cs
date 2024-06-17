using core_api.Features.Products.Models;
using core_api.Features.Purchases.Models;
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
    public DbSet<CreditCard> CreditCards { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<RelationalTransactionCreditCard> RelationalTransactionCreditCards { get; set; }

}