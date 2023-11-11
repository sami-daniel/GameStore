using GameStore.Models;

namespace GameStore.Repository.InterfacesContext;

public interface IProductRepository
{
    IEnumerable<Product> Products { get; }
    IEnumerable<Product> PreferredProducts { get; }
    Product GetProductById(int id);

}
