using Domian.Entities.Products;
using Domian.Entities.Receipts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Entities.Branchs;

[Table("branchs")]
public class Branch : Auditable
{
    [Column("branch_name")]
    public string BranchName { get; set; } = string.Empty;
    public List<ProductItem> ProductItems { get; set; } = new();
    public List<Receipt> Receipts { get; set; } = new();
}
