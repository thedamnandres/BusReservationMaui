using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusReservationMaui.ViewModels;

namespace BusReservationMaui.Views;

public partial class RutasView : ContentPage
{
    public RutasView()
    {
        InitializeComponent();
        BindingContext = new RutasViewModel();
    }

   protected override void OnAppearing()
{
    base.OnAppearing();

    var viewModel = BindingContext as RutasViewModel;
    if (viewModel?.Rutas != null)
    {
        int rowIndex = 0;

        // Limpiar las filas previas
        RutasGrid.RowDefinitions.Clear();
        RutasGrid.Children.Clear();

        foreach (var ruta in viewModel.Rutas)
        {
            // Crear una fila para cada ruta
            RutasGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            var frame = new Frame
            {
                CornerRadius = 10,
                Padding = 15,
                Margin = new Thickness(10, 5, 10, 5),
                BackgroundColor = Colors.White,
                HasShadow = true,
                Content = new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star }
                    },
                    RowDefinitions =
                    {
                        new RowDefinition { Height = GridLength.Auto },
                        new RowDefinition { Height = GridLength.Auto }
                    }
                }
            };

            var horaSalidaLabel = new Label
            {
                Text = ruta.HoraFormateada,
                FontSize = 18,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.Black,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            };
            Grid.SetRow(horaSalidaLabel, 0);
            Grid.SetColumn(horaSalidaLabel, 0);

            var duracionLayout = new VerticalStackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Spacing = 3,
                Children =
                {
                    new Label
                    {
                        Text = $"Duración {ruta.Duracion.Hours}h {ruta.Duracion.Minutes}m",
                        FontSize = 14,
                        TextColor = Colors.Gray,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Image
                    {
                        Source = "dotnet_bot.png",
                        HeightRequest = 20,
                        WidthRequest = 20,
                        HorizontalOptions = LayoutOptions.Center
                    }
                }
            };
            Grid.SetRow(duracionLayout, 0);
            Grid.SetColumn(duracionLayout, 1);

            var horaLlegadaLabel = new Label
            {
                Text = ruta.FechaSalida.ToString("HH:mm"),
                FontSize = 18,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.Black,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            };
            Grid.SetRow(horaLlegadaLabel, 0);
            Grid.SetColumn(horaLlegadaLabel, 2);

            var trayectoLabel = new Label
            {
                Text = $"{ruta.Origen} → {ruta.Destino}",
                FontSize = 14,
                TextColor = Colors.Gray,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };
            Grid.SetRow(trayectoLabel, 1);
            Grid.SetColumnSpan(trayectoLabel, 3);

            // Agregar los elementos al grid del frame
            var frameGrid = (Grid)frame.Content;
            frameGrid.Children.Add(horaSalidaLabel);
            frameGrid.Children.Add(duracionLayout);
            frameGrid.Children.Add(horaLlegadaLabel);
            frameGrid.Children.Add(trayectoLabel);

            // Agregar el frame al grid principal
            RutasGrid.Add(frame, 0, rowIndex);
            rowIndex++;
        }
    }
}
   
}
