using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusReservationMaui.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private static readonly Random random = new Random();

        public int ClienteId { get; set; } = random.Next(1, 11);
        public string Nombre { get; set; } = "Juan";
        public string Apellido { get; set; } = "Pérez";
        public string Email { get; set; } = "juan.perez@example.com";
        public string Telefono { get; set; } = "0991234567";
        public string Ciudad { get; set; } = "Quito";

        public UserViewModel() { }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
