using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1.Converters;
public class HigherLowerConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values == null || values.Length != 2 || !(values[0] is int) || !(values[1] is int))
        {
            return DependencyProperty.UnsetValue;
        }
        int currentValue = (int)values[0];
        int previousValue = (int)values[1];

        return currentValue > previousValue ? "너무 높음~~" : "너무 낮아~~";
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        return new object[2] { DependencyProperty.UnsetValue, DependencyProperty.UnsetValue };
    }
}
