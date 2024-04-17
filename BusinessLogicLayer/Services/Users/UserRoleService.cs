using BusinessLogicLayer.DTOs.Users;
using BusinessLogicLayer.Interfaces.Users;
using Domian.Entities.Users;

namespace BusinessLogicLayer.Services.Users;

public class UserRoleService : IUserRoleService
{
    public UserRoleService()
    {
        
    }
    public Task AddUserRoleAsync(AddUserRoleDto userRole)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserRole>> GetAll()
    {
        throw new NotImplementedException();
    }
}
