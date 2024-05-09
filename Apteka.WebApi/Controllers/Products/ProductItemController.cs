using BusinessLogicLayer.DTOs.Products;
using BusinessLogicLayer.Interfaces.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apteka.WebApi.Controllers.Products;

[Route("api/[controller]")]
[ApiController]
public class ProductItemController : ControllerBase
{
    private IProductItemService _productItemService;

    public ProductItemController(IProductItemService productItemService)
    {
        _productItemService = productItemService;
    }

    [HttpGet]
    public IActionResult GetAll()
    => Ok(_productItemService.GetAll());

    [HttpPost]
    public IActionResult Add(AddProductItemDto dto)
    => Ok(_productItemService.Add(dto));

    [HttpPut]
    public IActionResult Update(UpdateProductItemDto dto, Guid Id)
    => Ok(_productItemService.Update(dto, Id));

    [HttpDelete]
    public IActionResult Remove(Guid id)
    => Ok(_productItemService.Remove(id));
}
