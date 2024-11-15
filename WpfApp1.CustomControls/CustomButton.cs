using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.CustomControls;
public class CustomButton : Button
{
    public static readonly DependencyProperty IsHighlightedProperty =
        DependencyProperty.Register(nameof(IsHighlighted), typeof(bool),
            typeof(CustomButton), new PropertyMetadata(false));

    public bool IsHighlighted
    {
        get => (bool)GetValue(IsHighlightedProperty);
        set => SetValue(IsHighlightedProperty, value);
    }

    static CustomButton()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomButton),
            new FrameworkPropertyMetadata(typeof(CustomButton)));
    }
}
