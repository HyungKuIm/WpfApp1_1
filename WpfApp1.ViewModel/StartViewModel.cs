using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModel;
public class StartViewModel : BaseViewModel
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; NotifyPropertyChanged(); }
    }

    public StartViewModel()
    {
        Name = "HyungKu Im";
    }
}
