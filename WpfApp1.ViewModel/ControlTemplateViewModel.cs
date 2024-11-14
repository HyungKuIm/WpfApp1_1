using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.ViewModel.Commands;

namespace WpfApp1.ViewModel;
public class ControlTemplateViewModel : BaseViewModel
{
    public ICommand HelloCommand
    {
        get
        {
            return new ActionCommand(Action => Hello(), CanExecute => CanHello());
        }
    }

    private void Hello()
    {
        MessageBox.Show("안녕하세요~~");
    }

    private bool CanHello()
    {
        // 오전에만 활성화됨
        // 현재 시간 가져오기
        DateTime now = DateTime.Now;

        //오전인지 확인
        bool isMorning = now.Hour < 12;

        return isMorning;
    }
}
