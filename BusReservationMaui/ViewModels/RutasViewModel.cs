using System.Collections.ObjectModel;
using BusReservationMaui.Models;

namespace BusReservationMaui.ViewModels;

public class RutasViewModel
{
    public ObservableCollection<Ruta> Rutas { get; set; }

    public RutasViewModel()
    {
        // Simulación de datos
        Rutas = new ObservableCollection<Ruta>
        {
            new Ruta
            {
                RutaId = 1,
                Origen = "Terminal Norte",
                Destino = "Terminal Sur",
                Duracion = new TimeSpan(2, 30, 0),
                FechaSalida = DateTime.Now,
                Hora = new TimeSpan(9, 30, 0)
            },
            new Ruta
            {
                RutaId = 2,
                Origen = "Terminal Este",
                Destino = "Terminal Oeste",
                Duracion = new TimeSpan(1, 45, 0),
                FechaSalida = DateTime.Now,
                Hora = new TimeSpan(11, 30, 0)
            },
            new Ruta
            {
            RutaId = 3,
            Origen = "Terminal Este",
            Destino = "Terminal Oeste",
            Duracion = new TimeSpan(1, 45, 0),
            FechaSalida = DateTime.Now,
            Hora = new TimeSpan(11, 30, 0) 
            },
            new Ruta
            {
                RutaId = 4,
                Origen = "Terminal Este",
                Destino = "Terminal Oeste",
                Duracion = new TimeSpan(1, 45, 0),
                FechaSalida = DateTime.Now,
                Hora = new TimeSpan(11, 30, 0)
                
            }
        };
    }
}