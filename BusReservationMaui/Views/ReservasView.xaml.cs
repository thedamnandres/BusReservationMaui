using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusReservationMaui.Models;
using BusReservationMaui.ViewModel;

namespace BusReservationMaui.Views;

public partial class ReservasView : ContentPage
{
    public ReservasView()
    {
        InitializeComponent();
        BindingContext = new ReservaViewModel();

    }
}