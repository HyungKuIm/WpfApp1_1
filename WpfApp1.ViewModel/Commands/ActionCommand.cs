using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModel.Commands;
public class ActionCommand : ICommand
{
    readonly Action<object> action;
    readonly Predicate<object> canExecute;

    public ActionCommand(Action<object> action) : this(action, null) { }

    public ActionCommand(Action<object> action, Predicate<object> canExecute)
    {
        this.action = action;
        this.canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged
    {
        add
        {
            CommandManager.RequerySuggested += value;
        }
        remove
        {
            CommandManager.RequerySuggested -= value;
        }
    }

    

    public bool CanExecute(object? parameter)
    {
        return canExecute == null ? true : canExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        action(parameter);
    }
}
