using Microsoft.AspNetCore.Mvc;
using System;
using Training.Application.Reservas;

namespace Training.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaService _reservaService;

        public ReservaController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpGet("{userId}")]
        public IActionResult Get(Guid userId)
        {
            var reserva = _reservaService.Get(userId);

            return Ok(reserva);
        }

        [HttpPost]
        public IActionResult Post(ReservaDto reserva)
        {
            _reservaService.Create(reserva);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(ReservasUpdateDto reservationUpdate)
        {
            _reservaService.Update(reservationUpdate);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _reservaService.Delete(id);

            return Ok();
        }
    }
}
