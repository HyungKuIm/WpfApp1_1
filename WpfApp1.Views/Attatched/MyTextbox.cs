using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Views.Attatched;
public class MyTextbox : DependencyObject
{
    #region OnlyNumber

    public static readonly DependencyProperty OnlyNumberProperty =
        DependencyProperty.RegisterAttached("OnlyNumber",
            typeof(bool), typeof(MyTextbox),
            new PropertyMetadata(false, OnOnlyNumberChanged));

    public static void SetOnlyNumber(DependencyObject obj, bool value)
    {
        obj.SetValue(OnlyNumberProperty, value);
    }

    public static bool GetOnlyNumber(DependencyObject obj)
    {
        return (bool)obj.GetValue(OnlyNumberProperty);
    }

    private static void OnOnlyNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        TextBox textBox = (TextBox)d;
        bool newOnlyNumberValue = (bool)e.NewValue;
        if (newOnlyNumberValue)
        {
            textBox.PreviewTextInput += TextBox_PreviewTextInput;

        }
        else
        {
            textBox.PreviewTextInput -= TextBox_PreviewTextInput;
        }
    }

    private static void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
    {
        string text = e.Text;
        e.Handled = !IsTextValid(text);
    }

    private static bool IsTextValid(string text)
    {
        return Regex.Match(text, @"^\d*\.?\d*$").Success;
    }

    #endregion
}
