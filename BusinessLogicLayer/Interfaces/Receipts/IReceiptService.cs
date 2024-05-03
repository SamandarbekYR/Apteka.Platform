using BusinessLogicLayer.DTOs.Receipts;
using BusinessLogicLayer.Views.Receipts;
using Domian.Entities.Receipts;

namespace BusinessLogicLayer.Interfaces.Receipts;

public interface IReceiptService
{
    List<ReceiptView> GetAll();
    bool Add(AddReceiptDto dto);
    bool Remove(Guid id);
    bool Update(UpdateReceiptDto dto, Guid id);
}
