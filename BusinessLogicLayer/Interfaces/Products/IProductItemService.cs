using BusinessLogicLayer.DTOs.Products;
using Domian.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces.Products;

public interface IProductItemService
{
    public List<ProductItem> GetAll();
    bool Add(AddProductItemDto dto);
    bool Update(UpdateProductItemDto dto, Guid Id);
    bool Remove(Guid Id);
}