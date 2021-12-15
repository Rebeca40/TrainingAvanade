using System;

namespace Training.Application.Reservas
{
    public class ReservasUpdateDto
    {
        public Guid Id { get; set; }
        public DateTime NewExpectedDeliveryDate { get; set; }
    }
}
