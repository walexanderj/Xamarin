using CedeSistemasApp.Models;
using CedeSistemasApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CedeSistemasApp.ViewModels
{
    public class RestaurantsPageViewModels:BaseViewModel
    {
        private bool _IsRefreshing;
        public bool IsRefreshing {
            get { return _IsRefreshing; }
            set { _IsRefreshing = value;
                OnPropertyChanged("IsRefreshing");
            } 
        }

        public ObservableCollection<RestaurantModel> Restaurantes { get; set; }

        public RestaurantsPageViewModels()
        {
            Restaurantes = new ObservableCollection<RestaurantModel>();
            LoadRestaurantes();
        }

        async private void LoadRestaurantes()
        {

            IsRefreshing = true;
           foreach (var item in await new RestaurantRepository().GetRestaurants())
            {
                Restaurantes.Add(item);
            }
            IsRefreshing = false;
        }
    }
}
