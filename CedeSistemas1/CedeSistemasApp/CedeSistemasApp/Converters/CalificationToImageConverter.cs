using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace CedeSistemasApp.Converters
{
    public class CalificationToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           if(value==null)
                return value;

            var calificacion = (int)value;
            if (calificacion<= 2)
            {
                return "bad";
            }
            else if (calificacion == 3)
            {
                return "neutro";
            }
            else
            {
                return "Bueno";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
