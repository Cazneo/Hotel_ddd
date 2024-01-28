using Reservation_API.DTOs;
using Reservation_API.Model;
using Reservation_API.Repository;

namespace Reservation_API.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task CreateReservationAsync(Reservation reservation)
        {
            await _reservationRepository.AddAsync(reservation);
        }

        public async Task<bool> DeleteReservationAsync(int id)
        {
          return await _reservationRepository.DeleteAsync(id);
        }

        public async Task<Reservation> GetReservationByIdAsync(int id)
        {
            var reservation = await _reservationRepository.GetByIdAsync(id);
            return reservation;
        }


        public async Task<bool> UpdateReservationAsync(int id, ReservationDto reservationDto)
        {
            var reservation = await _reservationRepository.GetByIdAsync(id);
            if (reservation == null) return false;
            reservation.UtilisateurID = reservationDto.UtilisateurID;
            reservation.DateEntree = reservationDto.DateEntree;
            reservation.NombreNuits = reservationDto.NombreNuits;
            reservation.ChambreID = reservationDto.ChambreID;
            reservation.Confirmation = reservationDto.Confirmation;
            reservation.SommeReservation = reservationDto.SommeReservation;

            await _reservationRepository.UpdateAsync(reservation);
            return true;
        }

    }
}
