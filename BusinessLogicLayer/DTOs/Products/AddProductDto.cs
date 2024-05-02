using Domian.Entities.Categories;
using Domian.Entities.Products;
using Domian.Entities.Receipts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs.Products;

public class AddProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public double Tax { get; set; }
    public Guid CategoryId { get; set; }
}
