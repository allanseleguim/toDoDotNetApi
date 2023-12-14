// Task.cs
using System.ComponentModel.DataAnnotations;

public class Task
{
    public int Id { get; set; }

    [Required]
    public string TaskName { get; set; }

    public string TaskDescription { get; set; }

    public bool TaskDone { get; set; }
}
