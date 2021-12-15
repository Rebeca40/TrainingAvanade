using System;
using System.Collections.Generic;
using System.Linq;
using Training.Application.Reservations;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Reservas
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public IEnumerable<ReservaDto> Get(Guid userId)
         {
            return _reservaRepository
                .GetByUser(userId)
                .Select(x => MapEntity(x));
        }

        public void Create(ReservaDto reservaDto)
        {
            var reserva = MapDto(reservaDto);

            _reservaRepository.Create(reserva);
        }

        public void Update(ReservasUpdateDto reservaUpdateDto)
        {
            var reserva = _reservaRepository.GetById(reservaUpdateDto.Id);

            reserva.ExpectedDeliveryDate = reservaUpdateDto.NewExpectedDeliveryDate;

            _reservaRepository.Update(reserva);
        }

        public void Delete(Guid id)
        {
            var reserva = _reservaRepository.GetById(id);

            reserva.IsDeleted = true;

            _reservaRepository.Update(reserva);
        }

        private ReservaDto MapEntity(Reserva entity)
        {
            return new ReservaDto
            {
                Id = entity.Id,
                UserId = entity.UserId,
                BookId = entity.BookId,
                CreationDate = entity.CreationDate,
                ExpectedDeliveryDate = entity.ExpectedDeliveryDate,
            };
        }

        private Reserva MapDto(ReservaDto entity)
        {
            return new Reserva
            {
                Id = entity.Id,
                UserId = entity.UserId,
                BookId = entity.BookId,
                CreationDate = entity.CreationDate,
                ExpectedDeliveryDate = entity.ExpectedDeliveryDate,
            };
        }
    }
}
