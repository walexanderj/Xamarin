using CedeSistemasApp.Interfaces;
using CedeSistemasApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceService))]
namespace CedeSistemasApp.Services
{

    public class DeviceService : IDeviceService
    {
        public bool CheckConnectivity()
        {
            var current = Connectivity.NetworkAccess;
            if(current == NetworkAccess.Internet)
            {
                return true;
            }
            return false;
        }

        async public void OpenBrowser(string url)
        {
            if (CheckConnectivity())
            {
                var uri = new Uri(url);
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
        }

        public void PlacePhoneCall(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}
