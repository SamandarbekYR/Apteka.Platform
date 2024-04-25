using BusinessLogicLayer.DTOs.Users;
using Domian.Entities.Users;

namespace BusinessLogicLayer.Interfaces.Users;

public interface IUserRoleService
{
    void Add(AddUserRoleDto userRole);
    List<UserRole> GetAll();
    void Update(AddUserRoleDto userRole, Guid Id);
    void Remove(Guid Id);

}
