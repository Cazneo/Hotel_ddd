using Payment_API.Model;
using Payment_API.DTOs;

namespace Payment_API.Services
{
    public interface IDeviseService
    {
        Task CreateDeviseAsync(Devise devise);
        Task<Devise> GetDeviseByIdAsync(int id);
        Task<bool> UpdateDeviseAsync(int id, DeviseDto deviseDto);
        Task<bool> DeleteDeviseAsync(int id);
    }
}
