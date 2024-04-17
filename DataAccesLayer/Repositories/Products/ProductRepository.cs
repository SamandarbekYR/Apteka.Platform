using DataAccesLayer.Data;
using DataAccesLayer.Interfaces.Products;
using Domian.Entities.Products;

namespace DataAccesLayer.Repositories.Products;

public class ProductRepository(AppDbContext appDb) 
        : Repository<Product>(appDb), IProduct
{ }