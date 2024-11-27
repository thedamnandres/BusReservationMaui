namespace BusReservationMaui.Models;

public class Ruta
{
    public int RutaId { get; set; }
    public string Origen { get; set; }
    public string Destino { get; set; }
    public TimeSpan Duracion { get; set; }
    public DateTime FechaSalida { get; set; }
    public TimeSpan Hora { get; set; }
    
    public string HoraFormateada => $"{Hora.Hours:D2}:{Hora.Minutes:D2}";

}