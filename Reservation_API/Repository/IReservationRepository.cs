using Reservation_API.Model;

namespace Reservation_API.Repository
{
    public interface IReservationRepository
    {
        Task<Reservation> GetByIdAsync(int id);
        Task AddAsync(Reservation reservation);
        Task UpdateAsync(Reservation reservation);
        Task<bool> DeleteAsync(int id);
    }
}