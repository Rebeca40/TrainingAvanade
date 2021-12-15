using System;

namespace Training.Core.Models
{
    public class Reserva
    {
        public Guid Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public int IdLibro { get; set; }
        public string NombreLibro { get; set; }
        public bool IsDeleted { get; set; }
    }
}
