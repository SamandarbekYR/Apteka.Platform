﻿using AutoMapper;
using BusinessLogicLayer.DTOs.Braches;
using BusinessLogicLayer.DTOs.Categories;
using BusinessLogicLayer.DTOs.Products;
using BusinessLogicLayer.DTOs.Receipts;
using Domian.Entities.Branchs;
using Domian.Entities.Categories;
using Domian.Entities.Products;
using Domian.Entities.Receipts;

namespace BusinessLogicLayer.Commons.Mapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Branch, AddBranchDto>().ReverseMap()
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<Branch, UpdateBranchDto>().ReverseMap()
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<Receipt, AddReceiptDto>().ReverseMap()
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<Receipt, UpdateReceiptDto>().ReverseMap()
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<Category, AddCategoryDto>().ReverseMap()
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<Category, UpdateCategoryDto>().ReverseMap()
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<Product, AddProductDto>().ReverseMap()
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<Product, UpdateProductDto>().ReverseMap()
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<ProductItem, AddProductItemDto>().ReverseMap()
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<ProductItem, UpdateProductItemDto>().ReverseMap()
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<ReceiptItems, AddReceiptItemDto>().ReverseMap()
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<ReceiptItems, UpdateReceiptItemDto>().ReverseMap()
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
    }
}
