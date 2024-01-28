using Payment_API.DTOs;
using Payment_API.Model;

namespace Payment_API.Services
{
    public interface IWalletService
    {
        Task<Wallet> GetWalletByIdAsync(int id);
        Task CreateWalletAsync(Wallet wallet);
        Task<bool> UpdateWalletAsync(int id, WalletDto walletDto);
        Task<bool> DeleteWalletAsync(int id);
    }
}
