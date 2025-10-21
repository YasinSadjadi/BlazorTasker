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

    public override bool Equals(object? obj)
    {
        if (obj is not TaskerItem other)
            return false;
        if (id.Equals(other.id) ||
            Name.Equals(other.Name) ||
            Priority != other.Priority ||
            IsComplete != other.IsComplete) 
            return false;

        else
            return true;
    }
}
