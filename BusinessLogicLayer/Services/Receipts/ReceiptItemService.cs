using AutoMapper;
using BusinessLogicLayer.Commons.Exceptions;
using BusinessLogicLayer.DTOs.Receipts;
using BusinessLogicLayer.Interfaces.Receipts;
using DataAccesLayer.Interfaces;
using Domian.Entities.Receipts;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BusinessLogicLayer.Services.Receipts;

public class ReceiptItemService : IReceiptItemService
{
    private IUnitOfWork _dbSet;
    private IMapper _map;
    public ReceiptItemService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _dbSet = unitOfWork;
        _map = mapper;
    }
    public bool Add(AddReceiptItemDto dto)
    {
        ReceiptItems receiptItems = new ReceiptItems();
        ReceiptItems mapReceiptItem = _map.Map(dto,receiptItems);

        var result = _dbSet.ReceiptItem.Add(mapReceiptItem);

        if (result is false)
            throw new CustomException(HttpStatusCode.BadRequest, "Ma'lumot to'ldirishda qandaydir xatolik yuz berdi");

        return true;
    }

    public List<ReceiptItems> GetAll()
    {
        return _dbSet.ReceiptItem.GetAll()
            .AsNoTracking().ToList();
    }

    public bool Remove(Guid Id)
    {
        ReceiptItems? receiptItems = _dbSet.ReceiptItem.GetById(Id);
        if (receiptItems is null)
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");

        bool result = _dbSet.ReceiptItem.Remove(receiptItems);
        if (result is false)
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydir xatolik yuz berdi");

        return true;
    }

    public bool Update(UpdateReceiptItemDto dto, Guid Id)
    {
        ReceiptItems? receiptItems = _dbSet.ReceiptItem.GetById(Id);
        if (receiptItems is null)
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");
        
        receiptItems = _map.Map(dto, receiptItems);

        var result = _dbSet.ReceiptItem.Update(receiptItems);
        if (result is false)
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydir xatolik yuz berdi");

        return true;
    }
}
