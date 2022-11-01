using System;
using System.Windows;
using System.Windows.Input;
using WPF_HomeWork_14__MVVM_.Repository.Abstracts;
using WPF_HomeWork_14__MVVM_.Repository.Concrets;
using WPF_HomeWork_14__MVVM_.ViewModels;
using WPF_HomeWork_14__MVVM_.Views;

namespace WPF_HomeWork_14__MVVM_;

public partial class App : Application
{
    void ApplicationStart(object sender, StartupEventArgs e)
    {
        ICarRepository repository = new CarRepository();
        MainView view = new MainView();
        view.DataContext = new MainViewModel(repository);
        view.Show();
    }
}