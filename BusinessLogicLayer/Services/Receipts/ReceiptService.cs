using AutoMapper;
using BusinessLogicLayer.Commons.Exceptions;
using BusinessLogicLayer.DTOs.Receipts;
using BusinessLogicLayer.Interfaces.Receipts;
using BusinessLogicLayer.Views.Receipts;
using DataAccesLayer.Interfaces;
using Domian.Entities.Receipts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Receipts
{
    public class ReceiptService : IReceiptService
    {
        private IUnitOfWork _dbSet;
        private IMapper _map;

        public ReceiptService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _dbSet = unitOfWork;
            _map = mapper;
        }
        public bool Add(AddReceiptDto dto)
        {
            Receipt receipt = new Receipt() { Branch = null };
            Receipt mapReceipt = _map.Map(dto,receipt);
            var result = _dbSet.Receipt.Add(mapReceipt);

            if(result is false)
                throw new CustomException(HttpStatusCode.BadRequest, "Ma'lumot to'ldirishda qandaydir xatolik yuz berdi");

            return true;
        }

        public List<ReceiptView> GetAll()
        {
            var receipt = _dbSet.Receipt.SelectAll();

            return receipt.Select(c => (ReceiptView)c).ToList();
        }

        public bool Remove(Guid id)
        {
            Receipt? receipt = _dbSet.Receipt.GetById(id);
            if(receipt is null)
                throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");

            bool result = _dbSet.Receipt.Remove(receipt);
            if(result is false)
                throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydir xatolik yuz berdi");

            return true;
        }

        public bool Update(UpdateReceiptDto dto, Guid id)
        {
            Receipt receipt = _dbSet.Receipt.GetById(id);
            if(receipt is null)
                throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");

            receipt = _map.Map(dto,receipt);

            bool result = _dbSet.Receipt.Update(receipt);
            if (result is false)
                throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydir xatolik yuz berdi");

            return true;
        }
    }
}