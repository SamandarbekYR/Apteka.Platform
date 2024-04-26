using BCrypt.Net;
using BusinessLogicLayer.DTOs.Users;
using BusinessLogicLayer.Helper;
using BusinessLogicLayer.Interfaces.Users;
using BusinessLogicLayer.Views.Users;
using DataAccesLayer.Interfaces;
using Domian.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Users
{
    public class UserService : IUserService
    {
        private IUnitOfWork _userSet;

        public UserService(IUnitOfWork unitOfWork)
        {
            _userSet = unitOfWork;
        }
        public void AddUser(AddUserDto userDto)
        {
            (string Hash, string Salt) password = PasswordHasher.Hash(userDto.Password);
            
            User user = new User();
            user.CreatedAt = DateTime.UtcNow.AddHours(5);
            user.UpdatedAt = DateTime.UtcNow.AddHours(5);
            user.FullName = userDto.FullName;
            user.PhoneNumber = userDto.PhoneNumber;
            user.PasswordHash = password.Hash;
            user.PasswordSalt = password.Salt;
            user.RoleId = userDto.RoleId;
            user.Role = null;
            _userSet.User.Add(user);
        }

        public List<UserView> GetAll()
        {
            var users = _userSet.User.SelectAll();

            return users.Select(i => (UserView)i).ToList();
        }
    }
}
