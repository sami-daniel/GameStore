namespace GameStore.Models;
public class CompositeModels
{
    public IEnumerable<Category> Categories { get; set; }
    public IEnumerable<Product> Products { get; set; }

}
