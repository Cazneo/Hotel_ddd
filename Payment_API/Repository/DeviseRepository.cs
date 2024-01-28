using Microsoft.EntityFrameworkCore;
using Payment_API.Model;

namespace Payment_API.Repository
{
    public class DeviseRepository : IDeviseRepository
    {
        private readonly PaymentContext _context;

        public DeviseRepository(PaymentContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Devise devise)
        {
            await _context.Devises.AddAsync(devise);
            await _context.SaveChangesAsync();
        }

        public async Task<Devise> GetByIdAsync(int id)
        {
            return await _context.Devises.FindAsync(id);
        }

        public async Task UpdateAsync(Devise devise)
        {
            _context.Entry(devise).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var deviseToDelete = await _context.Devises.FindAsync(id);
            if (deviseToDelete == null) return false;

            _context.Devises.Remove(deviseToDelete);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
