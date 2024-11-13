using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.DataModels.Business;
using WpfApp1.ViewModel.Commands;
using WpfApp1.ViewModel.Interfaces;

namespace WpfApp1.ViewModel
{
    public class UserViewModel : BaseViewModel, IUserViewModel
    {
        private User user = new User();

        public User User { 
            get { return user; }
            set { user = value; NotifyPropertyChanged(); } 
        }

        public ICommand SaveCommand 
        {
            get {
                ActionCommand actionCommand = new ActionCommand(Action => Save(), CanExecute => CanSave());
                //actionCommand.RaiseCanExecuteChanged();
                return actionCommand; 
            }
        }

        private bool CanSave()
        {
            return User.Name.Trim().Length > 0;
        }

        private void Save()
        {
            // 사용자 객체 저장
            MessageBox.Show($"Save~~{User.Name}:{User.Age}");
        }
    }
}
