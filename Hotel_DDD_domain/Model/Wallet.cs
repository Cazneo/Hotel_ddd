namespace Hotel_DDD_domain.Model;

public class Portefeuille
{
    public int PortefeuilleID { get; set; }
    public int UtilisateurID { get; set; }
    public int DeviseID { get; set; }
    public float Montant { get; set; }
}
