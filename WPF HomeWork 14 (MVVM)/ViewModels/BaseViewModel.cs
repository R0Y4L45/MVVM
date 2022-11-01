using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_HomeWork_14__MVVM_.ViewModels;

public abstract class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void NotifyPropertyChanged([CallerMemberName] string propertyname = null) 
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
}
