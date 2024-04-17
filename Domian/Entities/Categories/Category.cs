using Domian.Entities.Products;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian.Entities.Categories;

[Table("categories")]
public class Category : Auditable
{
    [Column("category_name")]
    public string CategoryName { get; set; } = string.Empty;
    [Column("description")]
    public string Description { get; set; } = string.Empty;
    public List<Product> Products { get; set; } = new();
}
