using CedeSistemasApp.Models;
using CedeSistemasApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CedeSistemasApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantDetailPage : ContentPage
    {

        public RestaurantDetailPage(ViewModels.RestaurantDetailPageViewModel restaurantDetailPageViewModel)
        {
            InitializeComponent();
            BindingContext = restaurantDetailPageViewModel;
        }

        async private void btn_Map_Clicked(object sender, EventArgs e)
        {
            var vm = (RestaurantDetailPageViewModel)BindingContext;
            await Navigation.PushModalAsync(
                new MapPage(
                    vm.Item.Nombre,
                    vm.Item.Direccion,
                    vm.Item.Latitud,
                    vm.Item.Longitud
                    ));
        }
    }
}