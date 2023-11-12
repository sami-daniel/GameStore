using GameStore.Models;
using GameStore.Repository;
using GameStore.Repository.InterfacesContext;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers;
public class ProductController : Controller
{
    readonly IProductRepository productRepository;
    public ProductController(IProductRepository productRepository)
    {
        this.productRepository = productRepository; 
    }
    public IActionResult List()
    {
        var product = productRepository.Products;
        return View(product);
    }
}
