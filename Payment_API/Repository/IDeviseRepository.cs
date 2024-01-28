using Payment_API.Model;

namespace Payment_API.Repository
{
    public interface IDeviseRepository
    {
        Task AddAsync(Devise devise);
        Task<Devise> GetByIdAsync(int id);
        Task UpdateAsync(Devise devise);
        Task<bool> DeleteAsync(int id);
    }
}
