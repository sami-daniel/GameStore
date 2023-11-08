using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Models;
[Table(name: "Lanches")]
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required(ErrorMessage = "O nome do produto deve ser informado")]
    [Display(Name = "Nome")]
    [StringLength(maximumLength: 80,
        MinimumLength = 5,
        ErrorMessage = "O nome do produto deve ter no mínimo {1} caracteres e no maximo {0} caracteres")]
    public string ProductName { get; set; }
    [Required(ErrorMessage = "A descrição do produto deve ser informada")]
    [Display(Name = "Descrição curta")]
    [StringLength(maximumLength: 100,
        MinimumLength = 15,
        ErrorMessage = "A descrição do produto deve ter no mínimo {1} caracteres e no maximo {0} caracteres")]
    public string ProductShortDescription { get; set; }
    [Required(ErrorMessage = "A descrição detalhada do produto deve ser informada")]
    [Display(Name = "Descrição detalhada")]
    [StringLength(maximumLength: 800,
        MinimumLength = 50,
        ErrorMessage = "A descrição detalhada do produto deve ter no mínimo {1} caracteres e no maximo {0} caracteres")]
    public string ProductDetailedDescription { get; set; }
    [Display(Name = "Caminho imagem padrão")]
    public string ProductUrlImage { get; set; }
    [Display(Name = "Caminho imagem thumbnail")]
    public string ProductUrlThumbnailImage { get; set; }
    [Display(Name = "Preferido?")]
    public bool IsProductPreferred { get; set; }
    [Display(Name = "Está disponivel em estoque?")]
    public bool InStock { get; set; }
    [Required(ErrorMessage = "O preço do lanche deve ser informado")]
    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(5,2)")]
    [Range(1, 999.99,
        ErrorMessage = "O preço deve estar entre {0} e {1}")]
    public decimal ProductPrice { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}

