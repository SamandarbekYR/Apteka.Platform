namespace BusinessLogicLayer.DTOs.Receipts;

public class UpdateReceiptDto
{
    public Guid BranchId { get; set; }
    public double TotalPrice { get; set; } = default;
    public double TaxPrice { get; set; } = default;
}
