using DataAccesLayer.Data;
using DataAccesLayer.Interfaces.Branches;
using Domian.Entities.Branchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.Branches
{
    public class BranchRepository(AppDbContext appDb) 
           : Repository<Branch>(appDb), IBranch
    { }
}
