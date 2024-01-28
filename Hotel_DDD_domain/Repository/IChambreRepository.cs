using Hotel_DDD_domain.DTOs;

namespace Hotel_DDD_Domain.Repository
{
    public interface IChambreRepository
    {
        Task<ChambreDto> GetChambreByIdAsync(int chambreId);
        Task<IEnumerable<ChambreDto>> GetAllChambresAsync();
        Task<bool> IsChambreAvailableAsync(int chambreId, DateTime dateEntree, int nombreNuits);
        Task<float> CalculerSommeReservationAsync(int chambreId, int nombreNuits);
        float CalculerSommeReservation(int chambreId, int nombreNuits);
    }
}