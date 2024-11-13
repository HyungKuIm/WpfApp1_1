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

namespace WpfApp1.Views;
/// <summary>
/// WpfDataBinding.xaml에 대한 상호 작용 논리
/// </summary>
public partial class WpfDataBinding : UserControl
{
    private NameAdds nameadds;
    public WpfDataBinding()
    {
        InitializeComponent();

        nameadds = (NameAdds)FindResource("names");
    }

    private void insertbutton_Click(object sender, RoutedEventArgs e)
    {
        nameadds.Add(new NameAdd());
        //nameadds.Add(new NameAdd(txtName.Text, txtAddress.Text));
    }
}
