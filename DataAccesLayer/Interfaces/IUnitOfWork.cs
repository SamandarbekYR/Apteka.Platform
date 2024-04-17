using DataAccesLayer.Interfaces.Branches;
using DataAccesLayer.Interfaces.Categories;
using DataAccesLayer.Interfaces.Products;
using DataAccesLayer.Interfaces.Receipts;
using DataAccesLayer.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IUserRole UserRole { get; set; }
        public IUser User { get; set; }
        public ICategory Category { get; set; }
        public IProduct Product { get; set; }
        public IProductItem ProductItem { get; set; }
        public IReceipt Receipt { get; set; }
        public IReceiptItem ReceiptItem { get; set; }
        public IBranch Branch { get; set; }
    }
}
