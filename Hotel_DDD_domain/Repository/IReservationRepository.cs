using Hotel_DDD_domain.DTOs;
using Hotel_DDD_domain.Model;

namespace Hotel_DDD_Domain.Repository
{
    public interface IReservationRepository
    {
        Task<ReservationDto> GetReservationByIdAsync(int reservationId);
        Task<IEnumerable<ReservationDto>> GetReservationsByUtilisateurIdAsync(int utilisateurId);
        Task CreateAsync(Reservation reservation);
        Task UpdateAsync(ReservationDto reservationDto);
        Task DeleteAsync(int reservationId);
    }
}