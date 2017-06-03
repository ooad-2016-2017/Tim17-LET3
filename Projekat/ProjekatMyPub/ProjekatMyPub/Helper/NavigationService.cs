using ProjekatMyPub.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjekatMyPub.Helper
{
    public interface INavigationService
    {
        void Navigate(Type sourcePage);
        void Navigate(Type sourcePage, object parameter);
        void GoBack();
    }
}
public class NavigationService : INavigationService
{
    //obicna navigacija bez parametra
    public void Navigate(Type sourcePage)
    {
        var frame = (Frame)Window.Current.Content;
        frame.Navigate(sourcePage);
    }
    //navigiranje na page ali da se proslijedi parametar stranici
    public void Navigate(Type sourcePage, object parameter)
    {
        var frame = (Frame)Window.Current.Content;
        frame.Navigate(sourcePage, parameter);
    }
    //poziv da se vrati na predhodnu stranicu
    public void GoBack()
    {
        var frame = (Frame)Window.Current.Content;
        frame.GoBack();
    }
}
//Standardna relaycommand klasa koja se reuse u MVVM
public class RelayCommand<T> : ICommand
{
    private readonly Func<T, bool> _canExecuteMethod;
    private readonly Action<T> _executeMethod;
    #region Constructors
    public RelayCommand(Action<T> executeMethod)
    : this(executeMethod, null)
    {
    }
    public RelayCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
    {
        _executeMethod = executeMethod;
        _canExecuteMethod = canExecuteMethod;
    }
    #endregion Constructors
    #region ICommand Members
    public event EventHandler CanExecuteChanged;
    bool ICommand.CanExecute(object parameter)
    {
        try
        {
            return CanExecute((T)parameter);
        }
        catch { return false; }
    }
    void ICommand.Execute(object parameter)
    {
        Execute((T)parameter);
    }
    #endregion ICommand Members
    #region Public Methods
    public bool CanExecute(T parameter)
    {
        return ((_canExecuteMethod == null) || _canExecuteMethod(parameter));
    }
    public void Execute(T parameter)
    {
        if (_executeMethod != null)
        {
            _executeMethod(parameter);
        }
    }
    public void RaiseCanExecuteChanged()
    {
        OnCanExecuteChanged(EventArgs.Empty);
    }
    #endregion Public Methods
    #region Protected Methods
    protected virtual void OnCanExecuteChanged(EventArgs e)
    {
        var handler = CanExecuteChanged;
        if (handler != null)
        {
            handler(this, e);
        }
    }
    #endregion Protected Methods
}
