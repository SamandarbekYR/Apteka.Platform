using Domian.Entities.Categories;
using Domian.Entities.Receipts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian.Entities.Products;

[Table("products")]
public class Product : Auditable
{
    [Column("product_name")]
    public string ProductName { get; set; } = string.Empty;
    [Column("description")]
    public string Description { get; set; } = string.Empty;
    [Column("code")]
    public string Code { get; set; } = string.Empty;
    [Column("tax")]
    public double Tax { get; set; }
    [Column("category_id")]
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = new();
    public List<ProductItem> ProductItems { get; set; } = new();
    public List<ReceiptItems> ReceiptItems { get; set; }
}
