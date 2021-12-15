using System;
using System.Collections.Generic;

namespace Training.Application.Reservas
{
    public interface IReservaService
    {
        IEnumerable<ReservaDto> Get();
        ReservaDto Get(Guid id);
        void Create(ReservaDto reserva);
        void Update(ReservaDto reserva);
    }
}
