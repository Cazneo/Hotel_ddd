using User_API.Model;
using User_API.DTOs;

namespace User_API.Services
{
    public interface IUserService
    {
        Task CreateUserAsync(User user);
        Task<User> GetUserByIdAsync(int id);
        Task<bool> UpdateUserAsync(int id, UserDto userDto);
        Task<bool> DeleteUserAsync(int id);
    }
}
