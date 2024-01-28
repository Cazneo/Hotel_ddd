// ChambreService.cs
using AutoMapper;
using Hotel_DDD_Domain.Repository;
using Hotel_DDD_domain.DTOs;
using Hotel_DDD_domain.Model;

namespace Hotel_DDD_Domain.Service
{
    public class ChambreService
    {
        private readonly IChambreRepository _chambreRepository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ChambreService(IChambreRepository chambreRepository, IReservationRepository reservationRepository, IMapper mapper)
        {
            _chambreRepository = chambreRepository ?? throw new ArgumentNullException(nameof(chambreRepository));
            _reservationRepository = reservationRepository ?? throw new ArgumentNullException(nameof(reservationRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public ChambreDto GetChambreDetails(int chambreId)
        {
            var chambre = _chambreRepository.GetChambreById(chambreId);

            
            var chambreDto = _mapper.Map<ChambreDto>(chambre);

            return chambreDto;
        }

        public ReservationDto ReserverChambre(int chambreId, int utilisateurId, DateTime dateEntree, int nombreNuits)
        {
            var isChambreAvailable = _chambreRepository.IsChambreAvailableAsync(chambreId, dateEntree, nombreNuits);

            if (!isChambreAvailable)
            {
                throw new ApplicationException("La chambre n'est pas disponible pour la période spécifiée.");
            }

   
            var reservation = new Reservation
            {
                ChambreID = chambreId,
                UtilisateurID = utilisateurId,
                DateEntree = dateEntree,
                NombreNuits = nombreNuits,
                Confirmation = false 
            };

          
            reservation.SommeReservation = _chambreRepository.CalculerSommeReservationAsync(chambreId, nombreNuits);

         
            var reservationDto = _mapper.Map<ReservationDto>(reservation);

            
            _reservationRepository.Create(reservation);

            return reservationDto;
        }

 
    }
}
