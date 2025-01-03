using System;

namespace ToDoApp.Models;

public class Task
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? NotificationTime { get; set; }
}