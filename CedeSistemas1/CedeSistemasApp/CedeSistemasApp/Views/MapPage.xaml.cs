using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace CedeSistemasApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        private string nombre;
        private string direccion;
        private Double latitud;
        private Double longitud;

        public MapPage()
        {
            InitializeComponent();
        }

        public MapPage(string nombre, string direccion, Double latitud, Double longitud)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.latitud = latitud;
            this.longitud = longitud;
            InitializeComponent();
            SetPin();
        }

        private void SetPin()
        {
            var position = new Position(latitud, longitud);
            var pin = new Pin
            {
                Label = nombre,
                Address = direccion,
                Type = PinType.Place,
                Position = position
            };
            map.Pins.Add(pin);

            MapSpan mapSpan = MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(0.5));
            map.MoveToRegion(mapSpan);
        }
        async private void btn_close_Clicket(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}