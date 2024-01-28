
using Payment_API.DTOs;
using Payment_API.Model;
using Payment_API.Repository;

namespace Payment_API.Services
{
    public class DeviseService : IDeviseService
    {
        private readonly IDeviseRepository _deviseRepository;

        public DeviseService(IDeviseRepository deviseRepository)
        {
            _deviseRepository = deviseRepository;
        }

        public async Task CreateDeviseAsync(Devise devise)
        {
            await _deviseRepository.AddAsync(devise);
        }

        public async Task<Devise> GetDeviseByIdAsync(int id)
        {
            return await _deviseRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateDeviseAsync(int id, DeviseDto deviseDto)
        {
            var devise = await _deviseRepository.GetByIdAsync(id);
            if (devise == null) return false;

            devise.NomDevise = deviseDto.NomDevise;
            devise.TauxConversionEuro = deviseDto.TauxConversionEuro;

            await _deviseRepository.UpdateAsync(devise);
            return true;
        }

        public async Task<bool> DeleteDeviseAsync(int id)
        {
            return await _deviseRepository.DeleteAsync(id);
        }
    }
}
