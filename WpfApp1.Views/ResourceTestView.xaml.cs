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
/// ResourceTestView.xaml에 대한 상호 작용 논리
/// </summary>
public partial class ResourceTestView : UserControl
{
    public ResourceTestView()
    {
        InitializeComponent();
    }

    private void btnNormal_Click(object sender, RoutedEventArgs e)
    {
        label2.Style = null;
    }

    private void btnRes1_Click(object sender, RoutedEventArgs e)
    {
        Style style = (Style)FindResource("LabelStyle1");
        //style.Resources["FontSize"] = 20;
        style.Setters.Add(new Setter(Label.FontSizeProperty, 30));
    }

    private void btnRes2_Click(object sender, RoutedEventArgs e)
    {
        label2.Style = (Style)FindResource("LabelStyle2");
    }
}
