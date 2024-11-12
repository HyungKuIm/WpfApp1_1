using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DataModels.Enums;

namespace WpfApp1.DataModels;
public class PageModel : BaseDataModel
{
    private Type type = null;
    private Page page = Page.StartView;

    public PageModel(Type type, Page page)
    {
        Type = type;
        Page = page;
    }

    public Type Type
    {
        get { return type; }
        set { if (type != value) { type = value; NotifyPropertyChanged(); } }
    }

    public Page Page
    {
        get { return page; }
        set { if (page != value) { page = value; NotifyPropertyChanged(); } }
    }

    public override string ToString()
    {
        //throw new NotImplementedException();
        return $"{page.GetDescription()}";
    }
}
