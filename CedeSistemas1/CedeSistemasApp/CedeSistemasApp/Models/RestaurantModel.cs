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

        public Double Latitud { get; set; }

        public Double Longitud { get; set; }

        public int Calificacion { get; set; }
    }
}
