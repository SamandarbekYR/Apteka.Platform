using BusinessLogicLayer.DTOs.Receipts;
using BusinessLogicLayer.Interfaces.Receipts;
using Microsoft.AspNetCore.Mvc;

namespace Apteka.WebApi.Controllers.Receipts;

[Route("api/receiptItem")]
[ApiController]
public class ReceiptItemController : ControllerBase
{

    private IReceiptItemService _receiptItemService;

    public ReceiptItemController(IReceiptItemService receiptItemService)
    {
        _receiptItemService = receiptItemService;
    }

    [HttpGet]
    public IActionResult GetAll()
    => Ok(_receiptItemService.GetAll());

    [HttpPost]
    public IActionResult Add(AddReceiptItemDto dto)
    => Ok(_receiptItemService.Add(dto));

    [HttpPut]
    public IActionResult Update(UpdateReceiptItemDto dto, Guid Id)
    =>Ok(_receiptItemService.Update(dto, Id));

    [HttpDelete]
    public IActionResult Remove(Guid Id)
    =>Ok(_receiptItemService.Remove(Id));
}
