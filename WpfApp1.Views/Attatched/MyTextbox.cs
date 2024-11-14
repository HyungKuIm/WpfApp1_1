using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

    #region OnEnterKeyDown

    public static readonly DependencyProperty OnEnterKeyDownProperty
        = DependencyProperty.RegisterAttached("OnEnterKeyDown",
            typeof(ICommand), typeof(MyTextbox),
            new PropertyMetadata(OnOnEnterKeyDownChanged));

    public static ICommand GetOnEnterKeyDown(DependencyObject obj)
    {
        return (ICommand)obj.GetValue(OnEnterKeyDownProperty);
    }

    public static void SetOnEnterKeyDown(DependencyObject obj, ICommand value)
    {
        obj.SetValue(OnEnterKeyDownProperty, value);
    }

    private static void OnOnEnterKeyDownChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        TextBox textBox = (TextBox)d;
        if (e.OldValue == null && e.NewValue != null)
        {
            textBox.PreviewKeyDown += TextBox_PreviewKeyDown;
        }
        else if (e.OldValue != null && e.NewValue == null)
        {
            textBox.PreviewKeyDown -= TextBox_PreviewKeyDown;
        }
    }

    private static void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter || e.Key == Key.Return)
        {
            TextBox textBox = sender as TextBox;
            ICommand command = GetOnEnterKeyDown(textBox);
            if (command != null && command.CanExecute(textBox))
            {
                command.Execute(textBox);
            }
        }
    }

    #endregion
}
