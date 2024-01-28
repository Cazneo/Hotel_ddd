using System.Collections.Generic;
using Hotel_DDD_domain.DTOs;

namespace Hotel_DDD_Domain.Repository
{
    public interface IUserRepository
    {
        Task<UserDto> GetUserByIdAsync(int userId);
        Task<bool> DoesEmailExistAsync(string emailAddress);
        Task<bool> DoesPhoneNumberExistAsync(string phoneNumber);
        Task CreateAsync(UserDto userDto);
        Task UpdateAsync(UserDto userDto);
        Task DeleteAsync(int userId);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
    }
}
    