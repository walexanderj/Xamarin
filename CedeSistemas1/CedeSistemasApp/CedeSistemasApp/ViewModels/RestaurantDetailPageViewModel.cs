using CedeSistemasApp.Models;
using CedeSistemasApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CedeSistemasApp.ViewModels
{
    public class RestaurantDetailPageViewModel: BaseViewModel
    {
        private bool _IsRefreshing;
        public bool IsRefreshing
        {
            get { return _IsRefreshing; }
            set
            {
                _IsRefreshing = value;
                OnPropertyChanged("IsRefreshing");
            }
        }
        public ObservableCollection<ProductoModel> Productos { get; set; }
        public RestaurantModel Item { get; set; }

        public RestaurantDetailPageViewModel(RestaurantModel item)
        {
            this.Item = item;
            Productos = new ObservableCollection<ProductoModel>();
            LoadProductos(item.Id);
        }
        async private void LoadProductos(Guid idRestaurante)
        {

            IsRefreshing = true;
            //Productos =(List<ProductoModel>) await new RestaurantRepository().GetProducts(idRestaurante);
            foreach (var itemProduct in await new RestaurantRepository().GetProducts(idRestaurante))
            {
                Productos.Add(itemProduct);
            }
            IsRefreshing = false;
        }
    }
}
