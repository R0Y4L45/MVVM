using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WPF_HomeWork_14__MVVM_.Models;

namespace WPF_HomeWork_14__MVVM_.Views;

public partial class EditView : Window, INotifyPropertyChanged
{
    private Car _SelectedCar;

    public event PropertyChangedEventHandler? PropertyChanged;

    public Car SelectedCar
    {
        get { return _SelectedCar; }
        set { _SelectedCar = value; OnPropertyRaised(); }
    }


    private void OnPropertyRaised([CallerMemberName] string propertyname = null)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyname));

        }
    }

    public EditView()
    {
        InitializeComponent();
        DataContext = this;
    }
}
