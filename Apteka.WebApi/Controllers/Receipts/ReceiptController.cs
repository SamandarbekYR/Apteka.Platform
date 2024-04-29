using BusinessLogicLayer.DTOs.Receipts;
using BusinessLogicLayer.Interfaces.Receipts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apteka.WebApi.Controllers.Receipts;

[Route("api/receipt")]
[ApiController]
public class ReceiptController : ControllerBase
{
    private IReceiptService _receiptService;

    public ReceiptController(IReceiptService receiptService)
    {
        _receiptService = receiptService;
    }

    [HttpGet]
    public IActionResult GetAll()
    => Ok(_receiptService.GetAll());

    [HttpPost]
    public IActionResult Add(AddReceiptDto dto)
    => Ok(_receiptService.Add(dto));

    [HttpDelete]
    public IActionResult Remove(Guid Id)
    => Ok(_receiptService.Remove(Id));

    [HttpPut]
    public IActionResult Update(UpdateReceiptDto dto, Guid Id)
    => Ok(_receiptService.Update(dto, Id));
}
