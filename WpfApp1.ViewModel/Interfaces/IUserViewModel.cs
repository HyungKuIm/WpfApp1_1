using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.DataModels.Business;

namespace WpfApp1.ViewModel.Interfaces;
public interface IUserViewModel
{
    User User { get; set; }

    ICommand SaveCommand { get; }
}
