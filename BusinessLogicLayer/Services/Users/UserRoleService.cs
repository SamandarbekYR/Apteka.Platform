using BusinessLogicLayer.Commons.Exceptions;
using BusinessLogicLayer.DTOs.Users;
using BusinessLogicLayer.Interfaces.Users;
using DataAccesLayer.Interfaces;
using Domian.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BusinessLogicLayer.Services.Users;

public class UserRoleService : IUserRoleService
{
    private IUnitOfWork _dbSet;

    public UserRoleService(IUnitOfWork unitOfWork)
    {
        _dbSet = unitOfWork;
    }
    public void Add(AddUserRoleDto userRole)
    {
        UserRole role = new UserRole();
        role.CreatedAt = DateTime.UtcNow;
        role.UpdatedAt = DateTime.UtcNow;
        role.RoleName = userRole.RoleName;
        int result = _dbSet.UserRole.Add(role);

        if (result == 0)
        {
            throw new CustomException(HttpStatusCode.BadRequest, "Ma'lumot to'ldirishda qandaydur xatolik yuz berdi");
        }

        throw new CustomException(HttpStatusCode.Created, "So'rov muvafaqqiyatli amalga oshirildi");
    }

    public List<UserRole> GetAll()
    {
        return _dbSet.UserRole.GetAll()
                              .Include(c => c.User)
                              .AsNoTracking()
                              .ToList();
    }

    public void Remove(Guid Id)
    {
        UserRole? userRole = _dbSet.UserRole.GetById(Id);

        if (userRole is null)
        {
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");
        }

        int result = _dbSet.UserRole.Remove(userRole);

        if (result == 0)
        {
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");
        }

        throw new CustomException(HttpStatusCode.OK, "So'rov muvafaqqiyatli amalga oshirildi");
    }

    public void Update(AddUserRoleDto userRole, Guid Id)
    {
        UserRole? role = _dbSet.UserRole.GetById(Id);

        if (role == null)
        {
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");
        }

        int result = _dbSet.UserRole.Update(role);

        if (result == 0)
        {
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");
        }

        throw new CustomException(HttpStatusCode.OK, "So'rov muvafaqqiyatli amalga oshirildi");
    }
}
