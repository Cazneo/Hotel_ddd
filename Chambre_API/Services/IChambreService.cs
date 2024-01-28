using Chambre_API.Model;
using Chambre_API.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chambre_API.Services
{
    public interface IChambreService
    {
        Task<IEnumerable<ChambreDto>> GetAllChambres();
        Task<ChambreDto> GetChambreById(int id);
        Task<Chambre> AddChambre(Chambre chambre);
        Task UpdateChambre(Chambre chambre);
        Task DeleteChambre(int id);
        Task<bool> ChambreExists(int id);
    }
}
