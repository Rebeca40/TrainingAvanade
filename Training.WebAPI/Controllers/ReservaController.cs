using Microsoft.AspNetCore.Mvc;
using Training.Application.Reservas;
using Training.Core.Models;

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

        [HttpGet]
        public IActionResult Get()
        {
            var reservas = _reservaService.Get();

            return Ok(reservas);
        }


        [HttpPost]
        public IActionResult Post(ReservaDto reserva)
        {
            _reservaService.Create(reserva);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(ReservaDto reserva)
        {
            _reservaService.Update(reserva);

            return Ok();
        }
    }
}
