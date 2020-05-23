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
    public partial class RestaurantsPage : ContentPage
    {
        public RestaurantsPage()
        {
            InitializeComponent();
            BindingContext = new RestaurantsPageViewModels();
        }

        async private void grd_restaurants_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item =(RestaurantModel) e.SelectedItem;
            if (item == null)
                return;

            await Navigation.PushAsync(new RestaurantDetailPage(new RestaurantDetailPageViewModel(item)));
            grd_restaurants.SelectedItem = null;
        }
    }
}