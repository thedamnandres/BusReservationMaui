using System;
using BusReservationMaui.Models;
using BusReservationMaui.ViewModels;
using Microsoft.Maui.Controls;

namespace BusReservationMaui.Views
{
    public partial class UserView : ContentPage
    {
        public UserView()
        {
            InitializeComponent();
            BindingContext = new UserViewModel(); 
        }

     
    }
}
