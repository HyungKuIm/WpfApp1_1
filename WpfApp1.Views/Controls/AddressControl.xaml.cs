using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.DataModels;

namespace WpfApp1.Views.Controls;
/// <summary>
/// AddressControl.xaml에 대한 상호 작용 논리
/// </summary>
public partial class AddressControl : UserControl
{
    public AddressControl()
    {
        InitializeComponent();
        
    }

    // public Address Address {get; set;} x

    public Address Address
    {
        get { return (Address)GetValue(AddressProperty); }
        set { SetValue(AddressProperty, value); }
    }

    public static readonly DependencyProperty AddressProperty =
        DependencyProperty.Register(nameof(Address), typeof(Address),
            typeof(AddressControl), new PropertyMetadata(new Address()));

    //private static void OnAddressPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    //{
    //    AddressControl ac = d as AddressControl;
    //    ac.OldAddress = (Address)e.OldValue;
    //    ac.NewAddress = (Address)e.NewValue;
        
    //}

    //public Address OldAddress { get; set; }
    //public Address NewAddress { get; set; }
}
