using Chambre_API.DTOs;

namespace Chambre_API.Dto
{
    public class ChambreDto
    {
        public int ChambreID { get; set; }
        public int TypeChambreID { get; set; }
        public List<EquipementDto> Equipements { get; set; } // Liste d'équipements

        public ChambreDto()
        {
            Equipements = new List<EquipementDto>();
        }
    }

}
