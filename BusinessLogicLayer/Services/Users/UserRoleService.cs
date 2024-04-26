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
    public bool Add(AddUserRoleDto userRole)
    {
        UserRole role = new UserRole();
        role.CreatedAt = DateTime.UtcNow;
        role.UpdatedAt = DateTime.UtcNow;
        role.RoleName = userRole.RoleName;
        
        bool result = _dbSet.UserRole.Add(role);

        if (result is false)
        {
            throw new CustomException(HttpStatusCode.BadRequest, "Ma'lumot to'ldirishda qandaydur xatolik yuz berdi");
        }

        return true;
    }

    public List<UserRole> GetAll()
    {
        return _dbSet.UserRole.GetAll()
                              .Include(c => c.User)
                              .AsNoTracking()
                              .ToList();
    }

    public bool Remove(Guid Id)
    {
        UserRole? userRole = _dbSet.UserRole.GetById(Id);

        if (userRole is null)
        {
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");
        }

        bool result = _dbSet.UserRole.Remove(userRole);

        if (result is false)
        {
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");
        }

        return true;
    }

    public bool Update(AddUserRoleDto userRole, Guid Id)
    {
        UserRole? role = _dbSet.UserRole.GetById(Id);

        if (role == null)
        {
            throw new CustomException(HttpStatusCode.NotFound, "Siz bergan Id bazada yo'q");
        }

        role.RoleName = userRole.RoleName;
        role.UpdatedAt = DateTime.UtcNow.AddHours(5);

        bool result = _dbSet.UserRole.Update(role);

        if (result is false)
        {
            throw new CustomException(HttpStatusCode.InternalServerError, "Tizimda qandaydur xatolik yuz berdi");
        }

        return true;
    }
}
