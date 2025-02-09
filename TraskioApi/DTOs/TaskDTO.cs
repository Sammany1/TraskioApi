using System;
using TraskioApi.Models;
public class TaskItemDTO
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int? ProjectId { get; set; }
    public int AssignedTo { get; set; }
    public string? Status { get; set; }
    public string? Priority { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public TaskItemDTO() { }
    public TaskItemDTO(Task task) =>
        (Id, Title, Description, ProjectId, AssignedTo, Status, Priority, StartDate, DueDate, CreatedAt, UpdatedAt) = (task.Id, task.Title, task.Description, task.ProjectId, task.AssignedTo, task.Status, task.Priority, task.StartDate, task.DueDate, task.CreatedAt, task.UpdatedAt);
}
