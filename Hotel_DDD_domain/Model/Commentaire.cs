namespace Hotel_DDD.Model;

public class Commentaire
{
    public int CommentaireID { get; set; }
    public int UtilisateurID { get; set; }
    public int ChambreID { get; set; }
    public int Note { get; set; }
    public string TexteCommentaire { get; set; }
    public DateTime DateCommentaire { get; set; }

}
