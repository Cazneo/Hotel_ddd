using Hotel_DDD_domain.DTOs;
using Hotel_DDD_domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_DDD_Domain.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly YourDbContext _context;

        public UserRepository(YourDbContext context)
        {
            _context = context;
        }

        public async Task<UserDto> GetUserByIdAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            // Conversion à UserDto
            return new UserDto(); // Remplacer par la conversion réelle
        }

        public async Task<bool> DoesEmailExistAsync(string emailAddress)
        {
            return await _context.Users.AnyAsync(u => u.EmailAddress == emailAddress);
        }

        public async Task<bool> DoesPhoneNumberExistAsync(string phoneNumber)
        {
            return await _context.Users.AnyAsync(u => u.PhoneNumber == phoneNumber);
        }

        public async Task CreateAsync(UserDto userDto)
        {
            var user = new User(); // Convertir UserDto en User
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(UserDto userDto)
        {
            // Trouver et mettre à jour l'utilisateur
        }

        public async Task DeleteAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
