using BusinessLogicLayer.DTOs.Users;
using Domian.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces.Users
{
    public interface IUserService
    {
        void AddUser(AddUserDto userDto);
        List<User> GetAll();
    }
}
