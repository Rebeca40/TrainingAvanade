using System;

namespace Training.Application.Reservas
{
    public class ReservaDto
    {
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaReserva { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreLibro { get; set; }
    }
}
