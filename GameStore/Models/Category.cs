namespace GameStore.Models;
public class Category
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
    public string? CategoryDescription { get; set; }
    public List<Product>? Products { get; set; }
}
