using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace GameStore.Models;
[Table("Categories")]
public class Category
{
    [Key]
    public int CategoryId { get; set; }
    [StringLength(maximumLength: 100,
        ErrorMessage = "O nome da categoria deve ser menor do que {0} caracteres")]
    [Required(ErrorMessage = "O nome da categoria deve ser informado")]
    [Display(Name = "Nome")]
    public string CategoryName { get; set; }
    [StringLength(maximumLength: 300,
        ErrorMessage = "A descrição da categoria deve ser menor do que {0} caracteres")]
    [Required(ErrorMessage = "A descrição da categoria deve ser informada")]
    [Display(Name = "Descrição")]
    public string CategoryDescription { get; set; }
    public List<Product> Products { get; set; }
}
