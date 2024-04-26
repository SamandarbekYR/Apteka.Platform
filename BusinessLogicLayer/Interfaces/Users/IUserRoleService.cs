using BusinessLogicLayer.DTOs.Users;
using Domian.Entities.Users;

namespace BusinessLogicLayer.Interfaces.Users;

public interface IUserRoleService
{
    bool Add(AddUserRoleDto userRole);
    List<UserRole> GetAll();
    bool Update(AddUserRoleDto userRole, Guid Id);
    bool Remove(Guid Id);

}
