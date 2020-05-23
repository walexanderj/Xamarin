using CedeSistemasApp.Interfaces;
using CedeSistemasApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
[assembly: Xamarin.Forms.Dependency(typeof(StorageService))]
namespace CedeSistemasApp.Services
{
    public class StorageService : IStorageService
    {

    }
}
