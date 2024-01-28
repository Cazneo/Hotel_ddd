namespace Hotel_DDD_domain.Model;
public class Reservation
{
    public int ReservationID { get; set; }
    public int ChambreID { get; set; }
    public int UtilisateurID { get; set; }
    public DateTime DateEntree { get; set; }
    public int NombreNuits { get; set; }
    public float SommeReservation { get; set; }
    public bool Confirmation { get; set; }

}
