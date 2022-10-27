using System;
using System.Globalization;
using System.Windows.Data;

namespace Gloomath.Converters
{
    public class BooleanToPrimeResult : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isPrime = (bool)value;

            return isPrime ? "é primo" : "não é primo";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}