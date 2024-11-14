using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1.Views.Commands;
public class TestCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private CommandView commandView;

    public TestCommand()
    {
        
    }

    public TestCommand(CommandView commandView)
    {
        this.commandView = commandView;
    }


    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        MessageBox.Show("TestCommand execute => " + parameter?.ToString());
        switch(parameter?.ToString())
        {
            case "Korea":
                this.commandView.ImageUri = "https://png.pngtree.com/background/20230425/original/pngtree-road-through-a-park-in-a-korean-autumn-leaves-landscape-wallpaper-picture-image_2467108.jpg";
                break;
            case "Japan":
                this.commandView.ImageUri = "https://www.aichi-now.jp/upload/amacolumns/large/760780935630704c328d64.jpg";
                break;
            case "China":
                this.commandView.ImageUri = "https://t1.daumcdn.net/thumb/R1280x0/?fname=http://t1.daumcdn.net/brunch/service/user/1jPF/image/3tksuIPhGWDJxGgbh8uqUxgAQGw.jpg";
                break;
            default:
                this.commandView.ImageUri = "https://png.pngtree.com/background/20230425/original/pngtree-road-through-a-park-in-a-korean-autumn-leaves-landscape-wallpaper-picture-image_2467108.jpg";
                break;
        }
        
    }
}
