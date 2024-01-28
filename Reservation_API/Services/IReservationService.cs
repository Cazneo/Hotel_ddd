using Reservation_API.DTOs;
using Reservation_API.Model;

namespace Reservation_API.Services
{
    public interface IReservationService
    {
        Task<Reservation> GetReservationByIdAsync(int id);
        Task CreateReservationAsync(Reservation reservation);
        Task<bool> UpdateReservationAsync(int id, ReservationDto reservationDto);
        Task<bool> DeleteReservationAsync(int id);
    }
}