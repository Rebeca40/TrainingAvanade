using System;
using System.Collections.Generic;

namespace Training.Application.Reservas
{
    public interface IReservaService
    {
        IEnumerable<ReservaDto> Get(Guid userId);
        void Create(ReservaDto reserva);
        void Update(ReservasUpdateDto reserva);
        void Delete(Guid id);
    }
}
