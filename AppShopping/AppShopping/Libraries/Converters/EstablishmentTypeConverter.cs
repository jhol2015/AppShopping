using AppShopping.Libraries.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppShopping.Libraries.Converters
{
    internal class EstablishmentTypeConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            EstablishmentType type = (EstablishmentType)value;

            return (type == EstablishmentType.Store) ? "Loja" : "Restaurante";
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
