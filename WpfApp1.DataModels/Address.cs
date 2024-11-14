using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataModels;
public class Address : BaseDataModel
{
    private string houseAndStreet, town, city, postCode;

    public string HouseAndStreet
    {
        get { return houseAndStreet; }
        set { if (houseAndStreet != value) { houseAndStreet = value; NotifyPropertyChanged(); } }
    }

    public string Town
    {
        get { return town; }
        set { if (town != value) { town = value; NotifyPropertyChanged(); } }
    }

    public string City
    {
        get { return city; }
        set { if (city != value) { city = value; NotifyPropertyChanged(); } }
    }

    public string PostCode
    {
        get { return postCode; }
        set { if (postCode != value) { postCode = value; NotifyPropertyChanged(); } }
    }

    public override string ToString()
    {
        return $"{HouseAndStreet}, {Town}, {City}, {PostCode}";
    }
}
