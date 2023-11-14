using GameStore.Models;

namespace GameStore.ViewModel;

public class ProductCategoryListViewModel
{
    public IEnumerable<Product> Products { get; set; }
    public IEnumerable<Category> Categories { get; set; }
}
