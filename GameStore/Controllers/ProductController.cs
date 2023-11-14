using GameStore.Migrations;
using GameStore.Models;
using GameStore.Repository;
using GameStore.Repository.InterfacesContext;
using GameStore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

namespace GameStore.Controllers;
public class ProductController : Controller
{
    readonly IProductRepository productRepository;
    readonly ICategoryRepository categoryRepository;
    public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        this.productRepository = productRepository;
        this.categoryRepository = categoryRepository;
    }
    public IActionResult List()
    {
        var enumerator = productRepository.Products.GetEnumerator();
        var productCategoryViewModel = new ProductCategoryListViewModel
        {
            Products = productRepository.Products.ToImmutableList(),
            Categories = categoryRepository.Categories.ToImmutableList()
        };
        var enumerator2 = productCategoryViewModel.Products.GetEnumerator();
        return View(productCategoryViewModel);
    }
}
