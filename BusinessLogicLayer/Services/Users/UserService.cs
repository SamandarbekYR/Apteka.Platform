using BCrypt.Net;
using BusinessLogicLayer.Commons.Exceptions;
using BusinessLogicLayer.DTOs.Users;
using BusinessLogicLayer.Helper;
using BusinessLogicLayer.Interfaces.Users;
using BusinessLogicLayer.Views.Users;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Interfaces.Users;
using Domian.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Users
{
    public class UserService : IUserService
    {
        private IUnitOfWork _dbSet;

        public UserService(IUnitOfWork unitOfWork)
        {
            _dbSet = unitOfWork;
        }
        public bool AddUser(AddUserDto userDto)
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
            _dbSet.User.Add(user);

            return true;
        }

        public List<UserView> GetAll()
        {
            var users = _dbSet.User.SelectAll();

            return users.Select(i => (UserView)i).ToList();
            //UserView userView = new();
            //List<UserView> usersList = new List<UserView>();
            //foreach (var user in users)
            //{
            //    userView.FullName = user.FullName;
            //    userView.PhoneNumber = user.PhoneNumber;
            //    userView.RoleName = user.Role.RoleName;
            //    usersList.Add(user);
            //} 
        }

        public bool Remove(Guid Id)
        {
            User? user = _dbSet.User.GetById(Id);

            if (user is null)
            {
                throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");
            }

            bool result = _dbSet.User.Remove(user);

            if (result is false)
            {
                throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");
            }

            return true;
        }

        public bool Update(UpdateUserDto userDto, Guid Id)
        {
            User? user = _dbSet.User.GetById(Id);

            if (user == null)
            {
                throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");
            }

            (string PasswordHash, string PasswordSalt) = PasswordHasher.Hash(userDto.Password);

            user.FullName = userDto.FullName;
            user.PhoneNumber = userDto.PhoneNumber;
            user.PasswordHash = PasswordHash;
            user.PasswordSalt = PasswordSalt;
            user.UpdatedAt = DateTime.UtcNow.AddHours(5);

            bool result = _dbSet.User.Update(user);

            if (result is false)
            {
                throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");
            }

            return true;
        }
    }
}
