using System.Windows;
using ToDoApp.ViewModels;

namespace ToDoApp.Views;

public partial class MainWindow : Window
{
    private MainViewModel _viewModel;
    
    
    public MainWindow()
    {
        InitializeComponent();
        
        _viewModel = new MainViewModel();
        DataContext = _viewModel;
    }
}