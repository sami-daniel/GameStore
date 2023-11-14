using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Models;

[Table("CartItem")]
public class CartItem
{
    [Key]
    public int CartItemId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public string CartId { get; set; }
}
