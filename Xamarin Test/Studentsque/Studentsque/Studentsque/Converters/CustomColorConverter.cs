using System;
using System.Globalization;
using Xamarin.Forms;

namespace Studentsque.Converters
{
    public class CustomColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var colorValue = value as string;
            var parameterValue = parameter as string;

            if (string.IsNullOrWhiteSpace(colorValue))
                return Color.Black;

            switch (colorValue)
            {
                case "BlaColor":
                    return string.IsNullOrWhiteSpace(parameterValue) ? Color.Red : Color.Blue;

                default:
                    return Color.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

