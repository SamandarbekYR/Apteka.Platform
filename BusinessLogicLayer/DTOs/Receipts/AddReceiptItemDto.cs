using Domian.Entities.Products;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogicLayer.DTOs.Receipts;

public class AddReceiptItemDto
{
    public Guid ProductId { get; set; }
    public Guid ReceiptId { get; set; }
    public int Amount { get; set; }
}
