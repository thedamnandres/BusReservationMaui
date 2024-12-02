using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusReservationMaui.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        // Implementación de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        // Método para notificar que una propiedad ha cambiado
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
