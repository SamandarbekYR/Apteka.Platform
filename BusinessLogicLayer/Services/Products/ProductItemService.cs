using AutoMapper;
using BusinessLogicLayer.Commons.Exceptions;
using BusinessLogicLayer.DTOs.Products;
using BusinessLogicLayer.Interfaces.Products;
using DataAccesLayer.Interfaces;
using Domian.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BusinessLogicLayer.Services.Products;

public class ProductItemService : IProductItemService
{
    private IUnitOfWork _dbSet;
    private IMapper _map;

    public ProductItemService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _dbSet = unitOfWork;
        _map = mapper;
    }
    public bool Add(AddProductItemDto dto)
    {
        ProductItem productItem = new ProductItem() { Product = null,Branch = null};
        productItem = _map.Map(dto, productItem);

        var result = _dbSet.ProductItem.Add(productItem);
        if (result is false)
            throw new CustomException(HttpStatusCode.BadRequest, "Ma'lumot to'ldirishda qandaydir xatolik yuz berdi");

        return true;
    }

    public List<ProductItem> GetAll()
    {
        return _dbSet.ProductItem.GetAll()
            .AsNoTracking().ToList();
    }

    public bool Remove(Guid Id)
    {
        ProductItem productItem = _dbSet.ProductItem.GetById(Id);

        if (productItem is null)
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada mavjud yo'q");

        var result = _dbSet.ProductItem.Remove(productItem);

        if (result is false)
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydir xatolik yuz berdi");

        return true;
    }

    public bool Update(UpdateProductItemDto dto, Guid Id)
    {
        ProductItem productItem = _dbSet.ProductItem.GetById(Id);

        if (productItem is null)
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada mavjud yo'q");

        productItem = _map.Map(dto,productItem);
        var result = _dbSet.ProductItem.Update(productItem);

        if (result is false)
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydir xatolik yuz berdi");

        return true;
    }
}
