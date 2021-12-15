using System;
using System.Collections.Generic;
using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class ReservaRepository : IReservaRepository
    {
        private List<Reserva> _reserva;

        public ReservaRepository()
        {
            _reserva = new List<Reserva>
            {
                new Reserva{ Id = Guid.NewGuid(), UserId = Guid.Parse("4c3b999f-64a5-4dce-a08c-c0d426944240"), CreationDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.Now.AddDays(15), BookId = Guid.NewGuid() },
                new Reserva{ Id = Guid.NewGuid(), UserId = Guid.Parse("4c3b999f-64a5-4dce-a08c-c0d426944240"), CreationDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.Now.AddDays(15), BookId = Guid.NewGuid() },
                new Reserva{ Id = Guid.NewGuid(), UserId = Guid.Parse("84d9e693-2340-4a96-886e-4eb410ca6bfe"), CreationDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.Now.AddDays(15), BookId = Guid.NewGuid() }
            };
        }

        public void Create(Reserva reserva)
        {
            _reserva.Add(reserva);
        }

        public Reserva GetById(Guid reservaId)
        {
            return _reserva.FirstOrDefault(x => x.Id == reservaId);
        }

        public IEnumerable<Reserva> GetByUser(Guid userId)
        {
            return _reserva.Where(x => x.UserId == userId && !x.IsDeleted);
        }

        public void Update(Reserva reserva)
        {
            _reserva = _reserva.Where(x => x.Id != reserva.Id).ToList();
            _reserva.Add(reserva);
        }
    }
}
