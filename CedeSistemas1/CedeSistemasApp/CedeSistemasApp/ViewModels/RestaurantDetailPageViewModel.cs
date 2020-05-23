using CedeSistemasApp.Interfaces;
using CedeSistemasApp.Models;
using CedeSistemasApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CedeSistemasApp.ViewModels
{
    public class RestaurantDetailPageViewModel: BaseViewModel
    {
        public ICommand OpenUrlCommand { get; set; }
        public ICommand PhoneCallCommand { get; set; }
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
            OpenUrlCommand = new Command(OpenUrl);
            PhoneCallCommand = new Command(PhoneCall);
            this.Item = item;
            Productos = new ObservableCollection<ProductoModel>();
            LoadProductos(item.Id);
        }

        private void PhoneCall(object obj)
        {
            var deviceService = DependencyService.Get<IDeviceService>();
            deviceService.PlacePhoneCall(obj.ToString());
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
        private void OpenUrl(Object url)
        {
            var deviceService = DependencyService.Get<IDeviceService>();
            deviceService.OpenBrowser(url.ToString());
        }
    }
}
