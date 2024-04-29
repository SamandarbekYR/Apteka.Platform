using BusinessLogicLayer.DTOs.Receipts;
using Domian.Entities.Receipts;

namespace BusinessLogicLayer.Interfaces.Receipts;

public interface IReceiptService
{
    List<Receipt> GetAll();
    bool Add(AddReceiptDto dto);
    bool Remove(Guid id);
    bool Update(UpdateReceiptDto dto, Guid id);
}
