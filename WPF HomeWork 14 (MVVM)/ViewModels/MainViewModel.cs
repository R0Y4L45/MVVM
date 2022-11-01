using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using MVVM.Models;
using MVVM.Repository.Abstracts;
using MVVM.ViewModels.Command;
using MVVM.Views;

namespace MVVM.ViewModels;

public class MainViewModel : BaseViewModel
{
    private readonly ICarRepository _carRepository;

    public ObservableCollection<Car> Cars { get; set; }
    private Car _SelectedCar;

    public Car SelectedCar { 
        get => _SelectedCar;
        set
        {
            _SelectedCar = value;
            NotifyPropertyChanged();
        }
    }

    public ICommand AddCommand { get; set; }
    public ICommand ShowCommand { get; set; }
    public ICommand EditCommand { get; set; }
    public ICommand DeleteCommand { get; set; }
    

    public MainViewModel(ICarRepository carRepository)
    {
        _carRepository = carRepository;
        Cars = new(_carRepository.GetList() ?? new List<Car>());

        //AddCommand = new RelayCommand(ExecuteAddCommand, CanExecuteAddCommand);
        ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand);
        EditCommand = new RelayCommand(ExecuteEditCommand, CanExecuteEditCommand);
        DeleteCommand = new RelayCommand(ExecuteDeleteCommand, CanExecuteDeleteCommand);
    }


    void ExecuteShowCommand(object? parameter) => MessageBox.Show(SelectedCar.Model);

    bool CanExecuteShowCommand(object? parameter) => SelectedCar is not null;

    void ExecuteEditCommand(object? parameter)
    {
        EditView _EditView = new EditView();
        _EditView.SelectedCar = SelectedCar;
        _EditView.Show();
    }

    bool CanExecuteEditCommand(object? parameter) => SelectedCar is not null;

    void ExecuteDeleteCommand(object? parameter) => Cars.Remove(SelectedCar);

    bool CanExecuteDeleteCommand(object? parameter) => SelectedCar is not null;
}
