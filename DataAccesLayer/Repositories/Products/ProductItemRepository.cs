using DataAccesLayer.Data;
using DataAccesLayer.Interfaces.Products;
using Domian.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.Products
{
    public class ProductItemRepository(AppDbContext appDb) 
          : Repository<ProductItem>(appDb), IProductItem
    { }
}
