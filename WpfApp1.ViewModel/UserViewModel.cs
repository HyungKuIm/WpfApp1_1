using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.DataModels;
using WpfApp1.ViewModel.Commands;
using WpfApp1.ViewModel.Interfaces;

namespace WpfApp1.ViewModel;
public class UserViewModel : BaseViewModel, IUserViewModel
{
    private User user = new User();

    public User User
    {
        get { return user; }
        set { user = value; NotifyPropertyChanged(); }
    }

    //public User User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public ICommand SaveCommand
    {
        get
        {
            return new ActionCommand(Action => Save());
        }
    }

    private void Save()
    {
        MessageBox.Show($"Save~~{User.Name}:{User.Age}\n주소:{User.Address}");
    }
}
