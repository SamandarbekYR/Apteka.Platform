using BusinessLogicLayer.DTOs.Users;
using BusinessLogicLayer.Views.Users;

namespace BusinessLogicLayer.Interfaces.Users;

public interface IUserService
{
    bool AddUser(AddUserDto userDto);
    bool Remove(Guid Id);
    bool Update(UpdateUserDto userDto, Guid Id);
    List<UserView> GetAll();
}
