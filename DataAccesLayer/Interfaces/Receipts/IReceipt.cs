using Domian.Entities.Receipts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces.Receipts
{
    public interface IReceipt : IRepository<Receipt> 
    {
        List<Receipt> SelectAll();
    }
}
