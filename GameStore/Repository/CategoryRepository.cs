using GameStore.Models;
using GameStore.Models.Context;
using GameStore.Repository.InterfacesContext;

namespace GameStore.Repository;

public class CategoryRepository : ICategoryRepository
{
    readonly AppDbContext context;

    public CategoryRepository(AppDbContext context)
    {
        this.context = context;
    }

    public IEnumerable<Category> Categories => context.Categories;
}
