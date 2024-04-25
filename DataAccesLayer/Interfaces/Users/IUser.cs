using Domian.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces.Users
{
    public interface IUser : IRepository<User>
    {
        List<User> SelectAll();
    }
}
