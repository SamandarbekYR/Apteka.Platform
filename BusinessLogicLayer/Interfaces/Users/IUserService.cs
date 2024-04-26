using BusinessLogicLayer.DTOs.Users;
using BusinessLogicLayer.Views.Users;

namespace BusinessLogicLayer.Interfaces.Users;

public interface IUserService
{
    void AddUser(AddUserDto userDto);
    List<UserView> GetAll();
}
