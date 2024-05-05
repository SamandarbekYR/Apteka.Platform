using AutoMapper;
using BusinessLogicLayer.Commons.Exceptions;
using BusinessLogicLayer.DTOs.Products;
using BusinessLogicLayer.Interfaces.Products;
using DataAccesLayer.Interfaces;
using Domian.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Products;

public class ProductService : IProductService
{
    private IUnitOfWork _dbSet;
    private IMapper _map;
    public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _dbSet = unitOfWork;
        _map = mapper;
    }
    public bool Add(AddProductDto dto)
    {
        Product product = new Product();
        Product mapProduct = _map.Map(dto, product);

        var result = _dbSet.Product.Add(mapProduct);

        if (result is false)
            throw new CustomException(HttpStatusCode.BadRequest, "Ma'lumot to'ldirishda qandaydir xatolik yuz berdi");

        return true;
    }

    public List<Product> GetAll()
    {
        return(_dbSet.Product.GetAll()
            .Include(c => c.ProductItems)
            .Include(c => c.ReceiptItems)
            .AsNoTracking()
            .ToList());
    }

    public bool Remove(Guid Id)
    {
        var product = _dbSet.Product.GetById(Id);

        if(product is null)
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada mavjud yo'q");

        var result = _dbSet.Product.Remove(product);

        if (result is false)
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydir xatolik yuz berdi");

        return true;
    }

    public bool Update(UpdateProductDto dto, Guid Id)
    {
        Product product = _dbSet.Product.GetById(Id);

        if (product is null)
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada mavjud yo'q");

        product = _map.Map(dto, product);

        var result = _dbSet.Product.Update(product);

        if (result is false)
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydir xatolik yuz berdi");

        return true;
    }
}
