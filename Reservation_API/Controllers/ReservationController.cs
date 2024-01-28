using Microsoft.AspNetCore.Mvc;
using Reservation_API.DTOs;
using Reservation_API.Model;
using Reservation_API.Services;
using System.Threading.Tasks;

namespace Reservation_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var reservation = await _reservationService.GetReservationByIdAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return Ok(reservation);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Reservation reservation)
        {
            await _reservationService.CreateReservationAsync(reservation);
            return CreatedAtAction(nameof(Get), new { id = reservation.ReservationID }, reservation);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ReservationDto reservationDto)
        {
            var success = await _reservationService.UpdateReservationAsync(id, reservationDto);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _reservationService.DeleteReservationAsync(id);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
