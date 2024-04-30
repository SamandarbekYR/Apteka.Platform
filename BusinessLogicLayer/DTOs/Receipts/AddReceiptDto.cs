namespace BusinessLogicLayer.DTOs.Receipts;

public class AddReceiptDto
{
    public Guid BranchId { get; set; }
    public double TotalPrice { get; set; } = default;
    public double TaxPrice { get; set; } = default;
}
