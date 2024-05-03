using Domian.Entities.Branchs;
using Domian.Entities.Receipts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Views.Receipts
{
    public class ReceiptView
    {
        public Guid Id { get; set; }
        public double TotalPrice { get; set; }
        public double TaxPrice { get; set; }
        public Guid BranchId { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public static implicit operator ReceiptView(Receipt receipt)
            => new()
            {
                Id = receipt.Id,
                BranchId = receipt.BranchId,
                TotalPrice = receipt.TotalPrice,
                TaxPrice = receipt.TaxPrice,
                BranchName = receipt.Branch.BranchName
            };
    }
}
