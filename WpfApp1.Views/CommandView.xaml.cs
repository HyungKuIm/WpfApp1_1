using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfApp1.Views.Commands;

namespace WpfApp1.Views;
/// <summary>
/// CommandView.xaml에 대한 상호 작용 논리
/// </summary>
public partial class CommandView : UserControl, INotifyPropertyChanged
{
    private string imageUri;

    public string ImageUri
    {
        get { return imageUri; }
        set { imageUri = value; 
            OnPropertyChanged(nameof(ImageUri));
            OnPropertyChanged(nameof(ImageSource));
        }
    }

    public CommandView()
    {
        InitializeComponent();
        DataContext = this;
        ImageUri = "https://png.pngtree.com/background/20230425/original/pngtree-road-through-a-park-in-a-korean-autumn-leaves-landscape-wallpaper-picture-image_2467108.jpg";
    }

    public object ImageSource
    {
        get
        {
            BitmapImage image = new BitmapImage();

            try
            {
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                image.UriSource = new Uri(ImageUri, UriKind.Absolute);
                image.EndInit();
            }
            catch
            {
                return DependencyProperty.UnsetValue;
            }

            return image;
        }
    }

    public ICommand Test
    {
        get { return new TestCommand(this); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
