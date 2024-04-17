using BusinessLogicLayer.DTOs.Users;
using Domian.Entities.Users;

namespace BusinessLogicLayer.Interfaces.Users;

public interface IUserRoleService
{
    Task AddUserRoleAsync(AddUserRoleDto userRole);
    Task<List<UserRole>> GetAll();
}
