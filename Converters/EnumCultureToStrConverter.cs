using System;
using System.Globalization;
using System.Windows.Data;
using WpfClientForm.Model;

namespace WpfClientForm.Converters
{
    public class EnumCultureToStrConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Culture c)
            {
                switch (c)
                {
                    case Culture.Fruits: return "Фрукты";
                    case Culture.Gargen: return "Сад";
                    case Culture.Grape: return "Виноград";
                    case Culture.Vegetables: return "Овощи";
                    default:
                        return null;
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
