using Payment_API.Model;

namespace Payment_API.Repository
{
    public interface IWalletRepository
    {
        Task<Wallet> GetByIdAsync(int id);
        Task AddAsync(Wallet wallet);
        Task UpdateAsync(Wallet wallet);
        Task<bool> DeleteAsync(int id);
    }
}
