using System;
using System.Windows;
using System.Windows.Input;
using MVVM.Repository.Abstracts;
using MVVM.Repository.Concrets;
using MVVM.ViewModels;
using MVVM.Views;

namespace MVVM;

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