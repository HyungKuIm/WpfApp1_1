using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DataModels;

namespace WpfApp1.ViewModel;
public class AllUsersViewModel : BaseViewModel
{
    private ObservableCollection<User> users = null;

    public AllUsersViewModel()
    {
        PopUsers();
    }

    private void PopUsers()
    {
        Users = new ObservableCollection<User>();
        Users.Add(new User(Guid.NewGuid(), "레오나르도 디카프리오", 50));
        Users.Add(new User(Guid.NewGuid(), "리차드 레드포드", 55));
        Users.Add(new User(Guid.NewGuid(), "티모시 살로멧", 30));
        Users.Add(new User(Guid.NewGuid(), "윤여정", 80));
    }

    public ObservableCollection<User> Users
    { 
        get { return users; }
        set { if (users != value) { users = value; NotifyPropertyChanged(); } }
    }
}
