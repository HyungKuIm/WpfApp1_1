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
using WpfApp1.ViewModel;

namespace WpfApp1.Views;
/// <summary>
/// CalendarVar.xaml에 대한 상호 작용 논리
/// </summary>
public partial class CalendarView : UserControl
{
    public CalendarView()
    {
        InitializeComponent();
    }

    private void beforeButton_Click(object sender, RoutedEventArgs e)
    {
        CalendarViewModel viewModel = DataContext as CalendarViewModel;
        MessageBox.Show(viewModel.YearMonth);
    }

    private void nextButton_Click(object sender, RoutedEventArgs e)
    {

    }
}
