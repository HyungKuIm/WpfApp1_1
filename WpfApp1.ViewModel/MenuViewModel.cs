using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.ViewModel.Commands;

namespace WpfApp1.ViewModel;
public class MenuViewModel : BaseViewModel
{
    private ObservableCollection<MenuItemViewModel> menuItems = 
        new ObservableCollection<MenuItemViewModel>();


    public MenuViewModel()
    {
        //KBO가 인기가 있어 외국에 팀을 소개하려고 한다.
        MenuItems.Add(new MenuItemViewModel() { 
            Header = "키음",
            Command = Command,
            MenuItems = new ObservableCollection<MenuItemViewModel>()
            {
                new MenuItemViewModel() {Header = "이정후", Command = Command},
                new MenuItemViewModel() {Header = "김혜성", Command = Command},
                new MenuItemViewModel() {Header = "김하성", Command = Command}
            }
        });
        MenuItems.Add(new MenuItemViewModel() { Header = "SSG", Command = Command });
        MenuItems.Add(new MenuItemViewModel() { Header = "Samsung", Command = Command });
        MenuItems.Add(new MenuItemViewModel() { Header = "Doosan", Command = Command });
    }

    public ObservableCollection<MenuItemViewModel> MenuItems
    {
        get { return menuItems; }
        set { menuItems = value; NotifyPropertyChanged(); }
    }

    public ICommand Command
    {
        get { return new ActionCommand(Action => MenuSelect(Action)); }
    }

    private void MenuSelect(object parameter)
    {
        MessageBox.Show("메뉴를 선택하셨습니다..");
        MessageBox.Show("선택하신 팀 or 선수:" + parameter.ToString());
    }
}
