using Domian.Entities.Branchs;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domian.Entities.Products;

[Table("product_items")]
public class ProductItem : Auditable
{
    [Column("manifactured_date")]
    public DateTime ManifacturedDate { get; set; }
    [Column("expired_date")]
    public DateTime ExpiredDate { get; set; }
    [Column("price")]
    public double Price { get; set; }
    [Column("amount")]
    public long Amount {  get; set; }
    [Column("amountper_collection")]
    public int AmountPerCollection { get; set; }
    [Column("product_id")]
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = new();
    [Column("branch_id")]
    public Guid BranchId { get; set; }
    [JsonIgnore]
    public Branch Branch { get; set; } = new();
}
