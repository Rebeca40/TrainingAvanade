using System;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IReservaRepository
    {
        Reserva Get(Guid id);
        void Create(Reserva reserva);
        void Update(Reserva reserva);
    }
}
