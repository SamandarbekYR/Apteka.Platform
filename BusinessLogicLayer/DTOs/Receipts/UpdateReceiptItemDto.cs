namespace BusinessLogicLayer.DTOs.Receipts;

public class UpdateReceiptItemDto
{
    public Guid ProductId { get; set; }
    public Guid ReceiptId { get; set; }
    public int Amount { get; set; }
}
