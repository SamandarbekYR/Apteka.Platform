using BusinessLogicLayer.DTOs.Categories;
using BusinessLogicLayer.Interfaces.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apteka.WebApi.Controllers.Categories;

[Route("api/category")]
[ApiController]
public class CategoryController : ControllerBase
{
    private ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService; 
    }

    [HttpGet]
    public IActionResult GetAll()
    => Ok(_categoryService.GetAll());

    [HttpPost]
    public IActionResult Add(AddCategoryDto dto)
    => Ok(_categoryService.Add(dto));

    [HttpDelete]
    public IActionResult Remove(Guid Id)
    => Ok(_categoryService.Delete(Id));

    [HttpPut]
    public IActionResult Update(UpdateCategoryDto dto, Guid Id)
    => Ok(_categoryService.Update(dto, Id));
}
