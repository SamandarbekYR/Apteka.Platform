using AutoMapper;
using BusinessLogicLayer.DTOs.Braches;
using BusinessLogicLayer.DTOs.Categories;
using BusinessLogicLayer.DTOs.Products;
using BusinessLogicLayer.DTOs.Receipts;
using Domian.Entities.Branchs;
using Domian.Entities.Categories;
using Domian.Entities.Products;
using Domian.Entities.Receipts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Commons.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Branch, AddBranchDto>().ReverseMap();
            CreateMap<Receipt, AddReceiptDto>().ReverseMap();
            CreateMap<Category, AddCategoryDto>().ReverseMap();
            CreateMap<Product, AddProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
    }
}
