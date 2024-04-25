using BusinessLogicLayer.DTOs.Users;
using BusinessLogicLayer.Interfaces.Users;
using DataAccesLayer.Interfaces;
using Domian.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Services.Users;

public class UserRoleService : IUserRoleService
{
    private IUnitOfWork _dtSet;

    public UserRoleService(IUnitOfWork unitOfWork)
    {
        _dtSet = unitOfWork;
    }
    public void AddUserRole(AddUserRoleDto userRole)
    {
        UserRole role = new UserRole();
        role.CreatedAt = DateTime.UtcNow;
        role.UpdatedAt = DateTime.UtcNow;
        role.RoleName = userRole.RoleName;
        _dtSet.UserRole.Add(role);
    }

    public List<UserRole> GetAll()
    {
        return _dtSet.UserRole.GetAll()
                              .Include(c => c.User)
                              .AsNoTracking()
                              .ToList();
    }
}
