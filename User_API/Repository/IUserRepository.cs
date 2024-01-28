using User_API.Model;

namespace User_API.Repository
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User> GetByIdAsync(int id);
        Task UpdateAsync(User user);
        Task<bool> DeleteAsync(int id);
    }
}
