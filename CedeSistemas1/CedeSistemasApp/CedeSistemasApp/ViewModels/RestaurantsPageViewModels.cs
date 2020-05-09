using CedeSistemasApp.Models;
using CedeSistemasApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CedeSistemasApp.ViewModels
{
    public class RestaurantsPageViewModels
    {
        public ObservableCollection<RestaurantModel> Restaurantes { get; set; }

        public RestaurantsPageViewModels()
        {
            Restaurantes = new ObservableCollection<RestaurantModel>();
            LoadRestaurantas();
        }

        async private void LoadRestaurantas()
        {


           foreach (var item in await new RestaurantRepository().GetRestaurants())
            {
                Restaurantes.Add(item);
            }

        }
    }
}
