using Microsoft.EntityFrameworkCore;
using User_API.Model;

namespace User_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task UpdateAsync(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);
            if (userToDelete == null) return false;

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
