using GameStore.Models;
using GameStore.Models.Context;
using GameStore.Repository.InterfacesContext;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Repository;

public class ProductRepository : IProductRepository
{
    readonly AppDbContext context;

    public ProductRepository(AppDbContext context)
    {
        this.context = context;
    }

    public IEnumerable<Product> Products => context.Products.Include(p => p.Category);

    public IEnumerable<Product> PreferredProducts => context.Products.
        Where(p => p.IsProductPreferred == true).
        Include(p => p.Category);

    public Product GetProductById(int id) => context.Products.FirstOrDefault(p => p.ProductId == id);
}
