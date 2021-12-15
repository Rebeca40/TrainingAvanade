using System;
using System.Collections.Generic;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Reservas
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaService _reservaRepository;

        public ReservaService(IReservaService reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public IEnumerable<ReservaDto> Get()
        {
            throw new NotImplementedException();
        }

        public ReservaDto Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Create(ReservaDto dto)
        {
            var reserva = Map(dto);

            reserva.Id = Guid.NewGuid();

            _reservaRepository.Create(dto);
        }

        public void Update(ReservaDto reserva)
        {
            throw new NotImplementedException();
        }


        private Reserva Map(ReservaDto dto)
        {
            return new Reserva
            {
                FechaCreacion = dto.FechaCreacion,
                FechaDevolucion = dto.FechaReserva,
                NombreLibro = dto.NombreLibro
            };
        }

        private ReservaDto MapEntity(Reserva dto)
        {
            return new ReservaDto
            {
                FechaReserva = dto.FechaCreacion,
                FechaCreacion = dto.FechaDevolucion,
                NombreLibro = dto.NombreLibro
            };
        }
    }
}
