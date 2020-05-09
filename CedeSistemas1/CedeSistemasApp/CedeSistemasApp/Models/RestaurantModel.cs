using System;
using System.Collections.Generic;
using System.Text;

namespace CedeSistemasApp.Models
{
    public class RestaurantModel
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public Uri Imagen { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string SitioWeb { get; set; }

        public Decimal Latitud { get; set; }

        public Decimal Longitud { get; set; }


    }
}
