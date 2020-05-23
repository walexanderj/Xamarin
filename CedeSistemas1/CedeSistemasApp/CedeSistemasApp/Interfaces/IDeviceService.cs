using System;
using System.Collections.Generic;
using System.Text;

namespace CedeSistemasApp.Interfaces
{
    public interface IDeviceService
    {
        bool CheckConnectivity();
        void OpenBrowser(string url);

        void PlacePhoneCall(string phone);

    }
}
