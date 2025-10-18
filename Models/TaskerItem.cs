using System.ComponentModel.DataAnnotations;

namespace BlazorTasker.Models;

public class TaskerItem
{

    public Guid id { get; set; }

    [Required(ErrorMessage = "Every Task must have a name")]
    public string Name { get; set; } = string.Empty;
    public bool IsComplete { get; set; } = false;
}
