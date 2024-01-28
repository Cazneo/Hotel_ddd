using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chambre_API.Model
{
    public class EquipementChambre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EquipementID { get; set; }

        public int TypeChambreID { get; set; }

        public string? NomEquipement { get; set; }

   
        public TypeChambre? TypeChambre { get; set; }
    }
}
