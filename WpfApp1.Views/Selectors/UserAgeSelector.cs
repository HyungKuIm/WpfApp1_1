using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.DataModels;

namespace WpfApp1.Views.Selectors;
public class UserAgeSelector : DataTemplateSelector
{
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        FrameworkElement frameworkElement = container as FrameworkElement;

        if (frameworkElement != null && item != null && item is User user)
        {
            //OB
            if (user.Age >= 35)
            {
                return frameworkElement.FindResource("UserTemplate") as DataTemplate;
            } else
            {
                return frameworkElement.FindResource("InverseUserTemplate") as DataTemplate;
            }
        }

        return null;
    }
}
