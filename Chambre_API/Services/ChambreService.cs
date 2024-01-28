using Chambre_API.Dto;
using Chambre_API.DTOs;
using Chambre_API.Model;
using Chambre_API.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chambre_API.Services
{
    public class ChambreService : IChambreService
    {
        private readonly IChambreRepository _chambreRepository;

        public ChambreService(IChambreRepository chambreRepository)
        {
            _chambreRepository = chambreRepository;
        }

        public async Task<IEnumerable<ChambreDto>> GetAllChambres()
        {
            var chambres = await _chambreRepository.GetAll();
            return chambres.Select(c => new ChambreDto
            {
                ChambreID = c.ChambreID,
                TypeChambreID = c.TypeChambreID,
                Equipements = c.TypeChambre.Equipements.Select(e => new EquipementDto
                {
                    EquipementID = e.EquipementID,
                    NomEquipement = e.NomEquipement
                }).ToList()
            });
        }

        public async Task<ChambreDto> GetChambreById(int id)
        {
            var chambre = await _chambreRepository.GetById(id);
            if (chambre == null)
            {
                return null;
            }

            return new ChambreDto
            {
                ChambreID = chambre.ChambreID,
                TypeChambreID = chambre.TypeChambreID,
                Equipements = chambre.TypeChambre.Equipements.Select(e => new EquipementDto
                {
                    EquipementID = e.EquipementID,
                    NomEquipement = e.NomEquipement
                }).ToList()
            };
        }

        public async Task<Chambre> AddChambre(Chambre chambre)
        {
            await _chambreRepository.Add(chambre);
            return chambre;
        }

        public async Task UpdateChambre(Chambre chambre)
        {
            await _chambreRepository.Update(chambre);
        }

        public async Task DeleteChambre(int id)
        {
            await _chambreRepository.Delete(id);
        }

        public async Task<bool> ChambreExists(int id)
        {
            return await _chambreRepository.GetById(id) != null;
        }
    }
}
