using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM.ViewModels;

public abstract class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void NotifyPropertyChanged([CallerMemberName] string propertyname = null!) 
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
}
