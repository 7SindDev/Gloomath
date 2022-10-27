using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace Gloomath.Converters
{
    public class DifficultiesKindToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Dictionary<DifficultiesKind, string> keys = new Dictionary<DifficultiesKind, string>()
            {
                [DifficultiesKind.Easy] = "Fácil",
                [DifficultiesKind.Medium] = "Médio",
                [DifficultiesKind.Hard] = "Difícil"
            };

            DifficultiesKind key = (DifficultiesKind)value;

            return keys[key];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Dictionary<string, DifficultiesKind> keys = new Dictionary<string, DifficultiesKind>()
            {
                ["Fácil"] = DifficultiesKind.Easy,
                ["Médio"] = DifficultiesKind.Medium,
                ["Difícil"] = DifficultiesKind.Hard 
            };

            string key = (string)value;

            return keys[key];
        }
    }
}
