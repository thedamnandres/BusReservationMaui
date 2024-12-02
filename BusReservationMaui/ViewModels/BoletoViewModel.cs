using System;
using System.Collections.ObjectModel;
using BusReservationMaui.Models;

namespace BusReservationMaui.ViewModels
{
    public class BoletosViewModel : BaseViewModel
    {
        // Lista de boletos que se va a mostrar
        private ObservableCollection<Boleto> _boletos;
        public ObservableCollection<Boleto> Boletos
        {
            get => _boletos;
            set
            {
                _boletos = value;
                OnPropertyChanged(); // Notificar que la lista de boletos ha cambiado
            }
        }

        public BoletosViewModel()
        {
            // Inicializamos la lista de boletos
            Boletos = new ObservableCollection<Boleto>();

            // Simulación de recepción de un boleto tras una reserva
            // Esto normalmente lo harías cuando recibes un nuevo boleto después de la reserva
            RecibirBoleto(new Boleto
            {
                PasajeroNombre = "Juan Pérez",
                Asiento = "A1",
                FechaCompra = DateTime.Now,
                FechaViaje = DateTime.Now.AddDays(2)
            });
        }

        // Método para recibir y agregar un nuevo boleto
        public void RecibirBoleto(Boleto nuevoBoleto)
        {
            Boletos.Add(nuevoBoleto);
            OnPropertyChanged(nameof(Boletos)); // Notificar que la lista ha cambiado
        }
    }
}
