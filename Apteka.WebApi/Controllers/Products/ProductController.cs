using BusinessLogicLayer.DTOs.Products;
using BusinessLogicLayer.Interfaces.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apteka.WebApi.Controllers.Products;

[Route("api/product")]
[ApiController]
public class ProductController : ControllerBase
{
    private IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public IActionResult GetAll()
    => Ok(_productService.GetAll());

    [HttpPost]
    public IActionResult Add(AddProductDto dto)
    => Ok(_productService.Add(dto));

    [HttpDelete]
    public IActionResult Remove(Guid Id)
    => Ok(_productService.Remove(Id));

    [HttpPut]
    public IActionResult Update(UpdateProductDto dto, Guid Id)
     => Ok(_productService.Update(dto, Id));
}
