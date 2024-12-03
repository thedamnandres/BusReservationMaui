using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusReservationMaui.Models;

public class Reserva
{




    public int ReservaId { get; set; }


    public int ClienteId { get; set; }
    public User? Usuario { get; set; }


    public int RutaId { get; set; }
    public Ruta? Ruta { get; set; }


    public DateTime FechaReserva { get; set; }


    public string Asiento { get; set; }


    public string EstadoReserva { get; set; }


    public float Precio { get; set; }

    public Boleto? Boleto { get; set; }



}