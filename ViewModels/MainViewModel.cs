using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Avalonia.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shapes_task2.Models;

namespace Shapes_task2.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private int counter;
    
    public string X { get; set; }
    public string Y { get; set; }
    public string Radius { get; set; }
    public string Width { get; set; }
    public string Height { get; set; }
    
    public ICommand AddCircleCommand { get; }
    public ICommand AddRectangleCommand { get; }

    public ObservableCollection<Shape> Shapes { get; set; }

    public MainViewModel()
    {
        counter = 0;
        X = "0";
        Y = "0";
        Radius = "0";
        Width = "0";
        Height = "0";
        Shapes = new ObservableCollection<Shape>();

        AddCircleCommand = new RelayCommand(AddCircle);
        AddRectangleCommand = new RelayCommand(AddRectangle);
        
        AddCircle();
        AddRectangle();
    }

    private void AddCircle()
    {
        counter++;
        Shapes.Add(new Circle { X = Convert.ToInt32(X), Y = Convert.ToInt32(Y), Radius = Convert.ToInt32(Radius), Id=counter });
        OnPropertyChanged(nameof(Shapes));
    }

    private void AddRectangle()
    {
        counter++;
        Shapes.Add(new Rectangle { X = Convert.ToInt32(X), Y = Convert.ToInt32(Y), Width = Convert.ToInt32(Width), Height =
            Convert.ToInt32(Height), Id=counter });
        OnPropertyChanged(nameof(Shapes));
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}