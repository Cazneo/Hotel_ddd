namespace Reservation_API.DTOs
{
    public class ReservationDto
    {
        public int ChambreID { get; set; }
        public int UtilisateurID { get; set; }
        public DateTime DateEntree { get; set; }
        public int NombreNuits { get; set; }
        public float SommeReservation { get; set; }
        public bool Confirmation { get; set; }
    }
}
