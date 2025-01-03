using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace ToDoApp.ViewModels;

public class MainViewModel
{
    public ObservableCollection<TaskControlViewModel> TaskItems { get; } = new();
    
    public ICommand AddTaskCommand { get; }
    
    public MainViewModel()
    {
        AddTaskCommand = new RelayCommand(AddTask, CanAddTask);
    }
    
    private void AddTask()
    {
        TaskItems.Add(new TaskControlViewModel(this));
    }
    
    private bool CanAddTask() => true;
    
    public void RemoveTask(TaskControlViewModel task)
    {
        TaskItems.Remove(task);
    }
}