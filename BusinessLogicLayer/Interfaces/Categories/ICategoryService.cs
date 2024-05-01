using BusinessLogicLayer.DTOs.Categories;
using Domian.Entities.Categories;

namespace BusinessLogicLayer.Interfaces.Categories;

public interface ICategoryService
{
    List<Category> GetAll();
    bool Add(AddCategoryDto dto);
    bool Delete(Guid Id);
    bool Update(UpdateCategoryDto dto, Guid Id);
}
