using System;
using System.Collections.Generic;
using System.Linq;
namespace BusinessLogicLayer.DTOs.Products;

public class UpdateProductItemDto
{
    public double Price { get; set; }
    public long Amount { get; set; }
    public int AmountPerCollection { get; set; }
    public Guid ProductId { get; set; }
    public Guid BranchId { get; set; }
}
