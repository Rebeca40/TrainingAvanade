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
            _reserva = new List<Reserva>();
        }

        public void Create(Reserva reserva)
        {
            _reserva.Add(reserva);
        }

        public Reserva Get(Guid id)
        {
            return _reserva.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Reserva reserva)
        {
            throw new NotImplementedException();
        }
    }
}
