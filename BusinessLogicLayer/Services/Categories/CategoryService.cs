using AutoMapper;
using BusinessLogicLayer.Commons.Exceptions;
using BusinessLogicLayer.DTOs.Categories;
using BusinessLogicLayer.Interfaces.Categories;
using DataAccesLayer.Interfaces;
using Domian.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Categories;

public class CategoryService : ICategoryService
{
    private IUnitOfWork _dbSet;
    private IMapper _map;
    public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _dbSet = unitOfWork;
        _map = mapper;
    }

    public bool Add(AddCategoryDto dto)
    {
        Category category = new Category();
        Category mapCategory = _map.Map(dto,category);
        var result = _dbSet.Category.Add(mapCategory);

        if (result is false)
            throw new CustomException(HttpStatusCode.BadRequest, "Ma'lumot to'ldirishda qandaydur xatolik yuz berdi");

        return true;
    }

    public bool Delete(Guid Id)
    {
        Category category = _dbSet.Category.GetById(Id);

        if(category is null)
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");

        var result = _dbSet.Category.Remove(category);

        if(result is false)
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");

        return true;
    }

    public List<Category> GetAll()
    {
        return _dbSet.Category.GetAll()
            .Include(x => x.Products)
            .AsNoTracking()
            .ToList();
    }

    public bool Update(UpdateCategoryDto dto, Guid Id)
    {
        Category category = _dbSet.Category.GetById(Id);

        if (category is null)
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");

        category = _map.Map(dto,category);

        bool result = _dbSet.Category.Update(category);

        if (result is false)
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");

        return true;
    }
}
