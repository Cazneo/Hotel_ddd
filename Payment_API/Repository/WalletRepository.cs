using Microsoft.EntityFrameworkCore;
using Payment_API.Model;

namespace Payment_API.Repository
{
    public class WalletRepository : IWalletRepository
    {
        private readonly PaymentContext _context;

        public WalletRepository(PaymentContext context)
        {
            _context = context;
        }

        public async Task<Wallet> GetByIdAsync(int id)
        {
            return await _context.Wallets.FindAsync(id);
        }

        public async Task AddAsync(Wallet wallet)
        {
            await _context.Wallets.AddAsync(wallet);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Wallet wallet)
        {
            _context.Entry(wallet).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var walletToDelete = await _context.Wallets.FindAsync(id);
            if (walletToDelete == null) return false;

            _context.Wallets.Remove(walletToDelete);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}