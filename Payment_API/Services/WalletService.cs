using Payment_API.DTOs;
using Payment_API.Model;
using Payment_API.Repository;

namespace Payment_API.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;

        public WalletService(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public async Task<Wallet> GetWalletByIdAsync(int id)
        {
            return await _walletRepository.GetByIdAsync(id);
        }

        public async Task CreateWalletAsync(Wallet wallet)
        {
            await _walletRepository.AddAsync(wallet);
        }

        public async Task<bool> UpdateWalletAsync(int id, WalletDto walletDto)
        {
            var wallet = await _walletRepository.GetByIdAsync(id);
            if (wallet == null) return false;



            await _walletRepository.UpdateAsync(wallet);
            return true;
        }

        public async Task<bool> DeleteWalletAsync(int id)
        {
            return await _walletRepository.DeleteAsync(id);
        }
    }
}