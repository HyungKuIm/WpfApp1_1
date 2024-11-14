using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModel;
public class MenuItemViewModel : BaseViewModel
{
    private string header = string.Empty;
    private ICommand command = null;
    private ObservableCollection<MenuItemViewModel> menuItems = 
        new ObservableCollection<MenuItemViewModel>();

    public string Header
    {
        get { return header; }
        set { header = value; NotifyPropertyChanged(); }
    }

    public ICommand Command
    {
        get { return command; }
        set { command = value; NotifyPropertyChanged(); }
    }

    public ObservableCollection<MenuItemViewModel> MenuItems
    {
        get { return menuItems; }
        set { menuItems = value; NotifyPropertyChanged(); }
    }

}
