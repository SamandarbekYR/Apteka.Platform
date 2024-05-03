using DataAccesLayer.Data;
using DataAccesLayer.Interfaces.Receipts;
using Domian.Entities.Receipts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.Receipts
{
    public class ReceiptRepository(AppDbContext appDb) : Repository<Receipt>(appDb), IReceipt
    { 
        public AppDbContext _appDb = appDb;

        public List<Receipt> SelectAll()
        {
            return _appDb.Receipts.Include(c => c.Branch).AsNoTracking().ToList();
        }
    }
}
