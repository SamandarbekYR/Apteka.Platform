using AutoMapper;
using BusinessLogicLayer.Commons.Exceptions;
using BusinessLogicLayer.DTOs.Braches;
using BusinessLogicLayer.Interfaces.Branches;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Interfaces.Users;
using Domian.Entities.Branchs;
using Domian.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Branches
{
    public class BranchService : IBranchService
    {
        private IUnitOfWork _dbSet;
        private IMapper _map;

        public BranchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _dbSet = unitOfWork;
            _map = mapper;
        }
        public bool Add(AddBranchDto dto)
        {
            Branch branch = new Branch();
            Branch mapBranch = _map.Map(dto,branch);
            var result = _dbSet.Branch.Add(mapBranch);

            if (result is false)
            {
                throw new CustomException(HttpStatusCode.BadRequest, "Ma'lumot to'ldirishda qandaydur xatolik yuz berdi");
            }

            return true;
        }

        public List<Branch> GetAll()
        {
            return _dbSet.Branch.GetAll()
                          .Include(c => c.ProductItems)
                          .Include(c => c.Receipts)
                          .AsNoTracking()
                          .ToList();
        }

        public bool Remove(Guid Id)
        {
            Branch? branch = _dbSet.Branch.GetById(Id);

            if (branch is null)
            {
                throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");
            }

            bool result = _dbSet.Branch.Remove(branch);

            if (result is false)
            {
                throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");
            }

            return true;
        }

        public bool Update(UpdateBranchDto dto, Guid Id)
        {
            Branch? branch = _dbSet.Branch.GetById(Id);

            if (branch == null)
            {
                throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");
            }

            branch.BranchName = dto.BranchName;
            branch.UpdatedAt = DateTime.UtcNow.AddHours(5);

            bool result = _dbSet.Branch.Update(branch);

            if (result is false)
            {
                throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");
            }

            return true;
        }
    }
}
