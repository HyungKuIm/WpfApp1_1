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
/// RoutedEventTestView.xaml에 대한 상호 작용 논리
/// </summary>
public partial class RoutedEventTestView : UserControl
{
    public RoutedEventTestView()
    {
        InitializeComponent();
        WindowBubbling.MouseRightButtonDown += WindowBubbling_MouseLeftButtonDown;
    }

    private void WindowBubbling_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show("UserControl_MouseLeftButtonDown Event Exec");
    }

    private void btnMan_Click(object sender, RoutedEventArgs e)
    {
        string message = 
                $"#Sender:{sender.ToString()}\r\nSource:{e.Source}\r\nOrignal Source:{e.OriginalSource}";
        lstMessages.Items.Add(message);
        lstMessages.Items.Add("버튼이 클릭되었습니다.\r\n");
    }

    private void SomethingClicked(object sender, MouseButtonEventArgs e)
    {
        string message =
                $"#Sender:{sender.ToString()}\r\nSource:{e.Source}\r\nOrignal Source:{e.OriginalSource}";
        lstMessages.Items.Add(message);
        lstMessages.Items.Add("팩맨 이미지가 클릭되었습니다.\r\n");
        e.Handled = true;
    }

    private void WindowBubbling_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        Console.WriteLine("1: PreviewMouseDown_Window");
        string user = "김정일";
        if (user == "김정은")
        {
            e.Handled = true;
        } 
    }

    private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        Console.WriteLine("2: PreviewMouseDown_Grid");
    }

    private void btnMan_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        Console.WriteLine("3: PreviewMouseDown_Button");
    }

    private void Canvas_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        Console.WriteLine("4: PreviewMouseDown_Canvas");
    }
}
