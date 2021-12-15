using System;
using System.Collections.Generic;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IReservaRepository
    {
        IEnumerable<Reserva> GetByUser(Guid userId);
        Reserva GetById(Guid reservaId);
        void Create(Reserva reserva);
        void Update(Reserva reserva);
    }
}
