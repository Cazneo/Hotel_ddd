using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chambre_API.Model
{
    public class Chambre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChambreID { get; set; }

     
        public int TypeChambreID { get; set; }

   
        public TypeChambre? TypeChambre { get; set; }
    }
}
