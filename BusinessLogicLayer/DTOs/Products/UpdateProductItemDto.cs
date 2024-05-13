namespace BusinessLogicLayer.DTOs.Products;

public class UpdateProductItemDto
{
    public DateTime ManifacturedDate { get; set; }
    public DateTime ExpiredDate { get; set; }
    public double Price { get; set; }
    public long Amount { get; set; }
    public int AmountPerCollection { get; set; }
    public Guid ProductId { get; set; }
    public Guid BranchId { get; set; }
}
