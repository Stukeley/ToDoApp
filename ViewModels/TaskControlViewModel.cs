using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using ToDoApp.Models;

namespace ToDoApp.ViewModels;

public class TaskControlViewModel : INotifyPropertyChanged
{
    private readonly MainViewModel _parent;
    private readonly Task _task;
    
    // Polecenia.
    public ICommand ClearCommand { get; }
    
    // Właściwości.
    public string Title
    {
        get => _task.Title;
        set
        {
            if (_task.Title != value)
            {
                _task.Title = value;
                OnPropertyChanged();
            }
        }
    }
    
    public bool IsCompleted
    {
        get => _task.IsCompleted;
        set
        {
            if (_task.IsCompleted != value)
            {
                _task.IsCompleted = value;
                OnPropertyChanged();
            }
        }
    }
    
    public DateTime? NotificationTime
    {
        get => _task.NotificationTime;
        set
        {
            if (_task.NotificationTime != value)
            {
                _task.NotificationTime = value;
                OnPropertyChanged();
            }
        }
    }
    
    public TaskControlViewModel(MainViewModel parent)
    {
        _task = new Task();
        _parent = parent;
        
        ClearCommand = new RelayCommand(ClearTask, CanClearTask);
    }
    
    private void ClearTask()
    {
        _parent.RemoveTask(this);
    }
    
    private bool CanClearTask()
    {
        return true;
    }
    
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}