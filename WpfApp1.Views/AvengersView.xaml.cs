using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace WpfApp1.Views
{
    /// <summary>
    /// AvengersView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AvengersView : UserControl
    {
        private AvengersViewModel viewModel;
        public AvengersView()
        {
            InitializeComponent();
            Loaded += AvengersView_Loaded;
            //mediaElement.Play();
            
        }

        private void ViewModel_PlayRequested(object? sender, EventArgs e)
        {
            mediaElement.Source = new Uri(CreateAbsolutePathTo($"Images/{viewModel.VideoSource}"));
            mediaElement.Play();
        }

        private void AvengersView_Loaded(object sender, RoutedEventArgs e)
        {
            //Source="pack://application:,,,/WpfApp1;component/Images/braveNW.mp4"
            //mediaElement.Source = new Uri(CreateAbsolutePathTo("Images/braveNW.mp4"));
            //mediaElement.Play();
            if (DataContext != null)
            {
                viewModel = (AvengersViewModel)DataContext;
                viewModel.PlayRequested += ViewModel_PlayRequested;
            }
        }

        private static string CreateAbsolutePathTo(string mediaFile)
        {
            return System.IO.Path.Combine(new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName, mediaFile);
        }
    }
}


