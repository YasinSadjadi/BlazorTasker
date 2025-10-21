using System.ComponentModel.DataAnnotations;

namespace BlazorTasker.Models;

public class TaskerItem
{

    public TaskerItem()
    {
        CreatedDate = DateTime.Now;
    }

    public Guid id { get; set; }

    [Required(ErrorMessage = "Every Task must have a name")]
    public string Name { get; set; } = string.Empty;
    public bool IsComplete { get; set; } = false;
    public Priority Priority { get; set; } = Priority.High;

    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public DateTime? Deadline { get; set; }
}
