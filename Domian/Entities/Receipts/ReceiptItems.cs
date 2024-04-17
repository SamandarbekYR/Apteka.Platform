using Domian.Entities.Products;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian.Entities.Receipts;

[Table("receipt_items")]
public class ReceiptItems : Auditable
{
    [Column("product_id")]
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = new();
    [Column("receipt_id")]
    public Guid ReceiptId { get; set; }
    public Receipt Receipt { get; set; } = new();
    [Column("amount")]
    public int Amount { get; set; }
}
