using System.Collections.ObjectModel;

namespace BusReservationMaui.ViewModels;

public class HomeViewModel
{
    // ObservableCollection notifica a la vista si se modifica la lista
    public ObservableCollection<string> Images { get; set; }

    public HomeViewModel()
    {
        // Carga inicial de imágenes (pueden ser URLs o rutas locales)
        Images = new ObservableCollection<string>
        {
            "bus1.jpeg",
            "bus2.jpg",
            "dotnet_bot.png"
        };
    }
}