using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataModels.Business;
public class User : BaseDataModel
{
    private Guid id = Guid.Empty;
    private string name = string.Empty;
    private int age = 0;

    public User(Guid id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
    public User()
    {
        
    }

    // <summary>
    /// Gets or sets the unique identification number of the User object.
    /// </summary>
    public Guid Id
    {
        get { return id; }
        set { if (id != value) { id = value; NotifyPropertyChanged(); } }
    }

    /// <summary>
    /// Gets or sets the name of the User object.
    /// </summary>
    public string Name
    {
        get { return name; }
        set { name = value; NotifyPropertyChanged(); }
    }

    /// <summary>
    /// Gets or sets the age of the User object.
    /// </summary>
    public int Age
    {
        get { return age; }
        set { age = value; NotifyPropertyChanged(); }
    }

    public override string ToString()
    {
        return Name;
    }
}
