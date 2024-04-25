using BusinessLogicLayer.DTOs.Users;
using Domian.Entities.Users;

namespace BusinessLogicLayer.Interfaces.Users;

public interface IUserRoleService
{
    void AddUserRole(AddUserRoleDto userRole);
    List<UserRole> GetAll();
}
