using AutoMapper;
using BusinessLogicLayer.DTOs.Braches;
using BusinessLogicLayer.DTOs.Receipts;
using Domian.Entities.Branchs;
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
        }
    }
}
