using System;

namespace BusReservationMaui.Models
{
    public class Boleto
    {
        public string PasajeroNombre { get; set; }
        public string Asiento { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaViaje { get; set; }
    }
}
