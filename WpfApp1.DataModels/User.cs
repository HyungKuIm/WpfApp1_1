using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataModels;
public class User : BaseDataModel
{
    private Guid id = Guid.Empty;
    private string name = string.Empty;
    private int age = 0;
    private Address address = new Address();
    public Guid Id
    {
        get => id; // get { return id; }
        set { if (id != value) { id = value; NotifyPropertyChanged(); } }
    }

    public string Name
    {
        get => name; // get { return id; }
        set { if (name != value) { name = value; NotifyPropertyChanged(); } }
    }

    public int Age
    {
        get => age; // get { return id; }
        set { if (age != value) { age = value; NotifyPropertyChanged(); } }
    }

    public Address Address
    {
        get => address; // get { return id; }
        set { if (address != value) { address = value; NotifyPropertyChanged(); } }
    }

    public override string ToString()
    {
        return Name;
    }
}
