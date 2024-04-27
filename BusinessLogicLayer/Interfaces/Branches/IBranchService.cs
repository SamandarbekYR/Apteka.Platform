using BusinessLogicLayer.DTOs.Braches;
using Domian.Entities.Branchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces.Branches
{
    public interface IBranchService
    {
        List<Branch> GetAll();
        bool Add(AddBranchDto dto);
        bool Remove(Guid Id);
        bool Update (UpdateBranchDto dto, Guid Id);
    }
}
