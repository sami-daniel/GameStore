using GameStore.Models;
using System.Collections;

namespace GameStore.Repository.InterfacesContext;

public interface ICategoryRepository
{
    IEnumerable<Category> Categories { get; }
}
