using Microsoft.AspNetCore.Mvc;
using Chambre_API.Services;
using Chambre_API.Dto;
using System.Threading.Tasks;
using Chambre_API.Model;

namespace Chambre_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChambreController : ControllerBase
    {
        private readonly IChambreService _chambreService;

        public ChambreController(IChambreService chambreService)
        {
            _chambreService = chambreService;
        }

        // GET: /Chambre
        [HttpGet]
        public async Task<IActionResult> GetAllChambres()
        {
            var chambres = await _chambreService.GetAllChambres();
            return Ok(chambres);
        }

        // GET: /Chambre/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChambreById(int id)
        {
            var chambre = await _chambreService.GetChambreById(id);
            if (chambre == null)
            {
                return NotFound();
            }
            return Ok(chambre);
        }

        // POST: /Chambre
        [HttpPost]
        public async Task<IActionResult> CreateChambre([FromBody] ChambreDto chambreDto)
        {
            var chambre = ConvertDtoToChambre(chambreDto);
            var createdChambre = await _chambreService.AddChambre(chambre);
            return CreatedAtAction(nameof(GetChambreById), new { id = createdChambre.ChambreID }, createdChambre);
        }

        // PUT: /Chambre/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateChambre(int id, [FromBody] ChambreDto chambreDto)
        {
            var chambreExists = await _chambreService.ChambreExists(id);
            if (!chambreExists)
            {
                return NotFound();
            }

            var chambre = ConvertDtoToChambre(chambreDto);
            await _chambreService.UpdateChambre(chambre);
            return NoContent();
        }

        // DELETE: /Chambre/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChambre(int id)
        {
            var chambreExists = await _chambreService.ChambreExists(id);
            if (!chambreExists)
            {
                return NotFound();
            }

            await _chambreService.DeleteChambre(id);
            return NoContent();
        }

        private Chambre ConvertDtoToChambre(ChambreDto chambreDto)
        {
            return new Chambre
            {
                // Implémentez la logique de conversion ici
            };
        }
    }
}
