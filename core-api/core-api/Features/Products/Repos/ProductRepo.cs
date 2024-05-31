using core_api.Features.Products.Contracts;
using core_api.Features.Products.Models;
using core_api.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace core_api.Features.Products.Repos;

public class ProductRepo(DataContext context) : IProductRepo
{

    private readonly DbSet<Product> DataSet = context.Products;
    public async Task<IList<Product>> ListProductsAsync() 
        => await DataSet.ToListAsync();

    public async Task<IList<Product>> ListProductsByIdAsync(int id) 
        => await DataSet.Where(x => x.id == id).ToListAsync();

    public async Task<Product> AddProductAsync(Product product)
    {
        await DataSet.AddAsync(product);
        return product;
    }

    public async Task Commit()
    => await context.SaveChangesAsync();
}
