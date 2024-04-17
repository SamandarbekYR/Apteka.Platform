using DataAccesLayer.Data;
using DataAccesLayer.Interfaces.Categories;
using Domian.Entities.Categories;

namespace DataAccesLayer.Repositories.Categories;

public class CategoryRepository(AppDbContext appDb)
         : Repository<Category>(appDb), ICategory
{ }
