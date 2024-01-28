using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chambre_API.Model
{
    public class TypeChambre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeChambreID { get; set; }
        public string? NomType { get; set; }
        public float PrixParNuit { get; set; }

     
        public ICollection<EquipementChambre>? Equipements { get; set; }

        
        public ICollection<Chambre>? Chambres { get; set; }
    }
}
