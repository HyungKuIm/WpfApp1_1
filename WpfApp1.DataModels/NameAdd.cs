using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataModels;

public class NameAdds : ObservableCollection<NameAdd>
{

}

public class NameAdd : BaseDataModel
{
    private string name = string.Empty;  // 이름
    private string add = string.Empty;  // 주소

    public NameAdd() : this("이름입력", "주소입력")
    {
        
    }

    public NameAdd(string name, string add)
    {
        Name = name;
        Add = add;
    }

    public string Name
    {
        get { return name; }
        set { name = value; NotifyPropertyChanged(); }
    }

    public string Add
    {
        get { return add; }
        set { add = value; NotifyPropertyChanged(); }
    }

    public override string ToString()
    {
        return "이름 주소 모델";
    }
}
