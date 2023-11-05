namespace GameStore.Models;
public class Product
{
    public int ProductId{ get; set; }
    public string? ProductName { get; set; }
    public string? ProductShortDescription { get; set; }
    public string? ProductDetailedDescription { get; set;}
    public required string ProductUrlImage { get; set; }
    public required string ProductUrlThumbnailImage { get; set; }
    public bool IsProductPreferred { get; set; }
    public decimal ProductPrice { get; set; }
    public int? CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}

