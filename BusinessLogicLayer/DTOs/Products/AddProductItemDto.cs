namespace BusinessLogicLayer.DTOs.Products;

public class AddProductItemDto
{
    public double Price { get; set; }
    public long Amount { get; set; }
    public int AmountPerCollection { get; set; }
    public Guid ProductId { get; set; }
    public Guid BranchId { get; set; }
}
