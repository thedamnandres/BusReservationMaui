using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusReservationMaui.ViewModels;

namespace BusReservationMaui.Views;

public partial class HomeView : ContentPage
{
    public HomeView()
    {
        InitializeComponent();

        BindingContext = new HomeViewModel();
    }
}