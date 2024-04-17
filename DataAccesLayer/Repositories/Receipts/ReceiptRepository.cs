﻿using DataAccesLayer.Data;
using DataAccesLayer.Interfaces.Receipts;
using Domian.Entities.Receipts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.Receipts
{
    public class ReceiptRepository(AppDbContext apDb) : Repository<Receipt>(apDb), IReceipt
    { }
}
