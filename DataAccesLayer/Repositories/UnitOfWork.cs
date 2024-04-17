using DataAccesLayer.Data;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Interfaces.Branches;
using DataAccesLayer.Interfaces.Categories;
using DataAccesLayer.Interfaces.Products;
using DataAccesLayer.Interfaces.Receipts;
using DataAccesLayer.Interfaces.Users;
using DataAccesLayer.Repositories.Branches;
using DataAccesLayer.Repositories.Categories;
using DataAccesLayer.Repositories.Products;
using DataAccesLayer.Repositories.Receipts;
using DataAccesLayer.Repositories.Users;
using Domian.Entities.Receipts;

namespace DataAccesLayer.Repositories
{
    public class UnitOfWork(AppDbContext appDb) : IUnitOfWork
    {
        public IUserRole UserRole { get; set; } = new UserRoleRepository(appDb);
        public IUser User {  get; set; } = new UserRepository(appDb);
        public ICategory Category { get; set; } = new CategoryRepository(appDb);
        public IProduct Product { get; set; } = new ProductRepository(appDb);
        public IProductItem ProductItem {  get; set; } = new ProductItemRepository(appDb);
        public IReceipt Receipt { get; set; } = new ReceiptRepository(appDb);
        public IReceiptItem ReceiptItem { get; set; } = new ReceiptItemsRepository(appDb);
        public IBranch Branch { get; set; } = new BranchRepository(appDb);

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
