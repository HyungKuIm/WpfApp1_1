using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DataModels;

namespace WpfApp1.ViewModel;
public class NameAddViewModel : BaseViewModel
{
    private NameAdds nameAdds = null;
    private NameAdd nameAdd = null;

    public NameAdds NameAdds
    {
        get { return nameAdds; }
        set { nameAdds = value; NotifyPropertyChanged(); }
    }

    public NameAdd NameAdd
    { 
        get { return nameAdd; } 
        set { nameAdd = value; NotifyPropertyChanged(); } 
    }
    
}
