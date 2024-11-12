using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Loaded += MainWindow_Loaded;
        Closed += MainWindow_Closed;
    }

    private void MainWindow_Closed(object? sender, EventArgs e)
    {
        //throw new NotImplementedException();
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        //throw new NotImplementedException();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);
        MessageBoxResult result = MessageBox.Show("정말 닫으실래요?", "닫기 확인", MessageBoxButton.OKCancel, MessageBoxImage.Question);
        e.Cancel = result == MessageBoxResult.Cancel;
    }
}