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

namespace WpfApp1.Views;
/// <summary>
/// DependencyPropertyTest.xaml에 대한 상호 작용 논리
/// </summary>
public partial class DependencyPropertyTest : UserControl
{
    public DependencyPropertyTest()
    {
        InitializeComponent();
    }

    public static readonly DependencyProperty UserProperty =
        DependencyProperty.Register(
            "TextChange",
            typeof(string),
            typeof(DependencyPropertyTest),
            new FrameworkPropertyMetadata(
                "홍길동",
                new PropertyChangedCallback(OnTextChangePropertyChanged)));

    private static void OnTextChangePropertyChanged(DependencyObject d, 
        DependencyPropertyChangedEventArgs e)
    {
        DependencyPropertyTest userNamecontrol = d as DependencyPropertyTest;
        string newText = e.NewValue as string;
        string oldText = e.OldValue as string;

        userNamecontrol.txtNewText.Text = newText;
        userNamecontrol.txtOldText.Text = oldText;
    }

    public string UserText
    {
        get { return (string)GetValue(UserProperty); }
        set { SetValue(UserProperty, value); }
    }

    private void btnChange_Click(object sender, RoutedEventArgs e)
    {
        UserText = textBox1.Text;
    }
}
