using BusinessLogicLayer.DTOs.Products;
using Domian.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces.Products;

public interface IProductService
{
    List<Product> GetAll();
    bool Add(AddProductDto dto);
    bool Remove(Guid Id);
    bool Update(UpdateProductDto dto, Guid Id);
}
