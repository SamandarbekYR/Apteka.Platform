using BusinessLogicLayer.DTOs.Receipts;
using Domian.Entities.Receipts;

namespace BusinessLogicLayer.Interfaces.Receipts;

public interface IReceiptItemService
{
    List<ReceiptItems> GetAll();
    bool Add(AddReceiptItemDto dto);
    bool Update(UpdateReceiptItemDto dto, Guid Id);
    bool Remove(Guid Id);
}
