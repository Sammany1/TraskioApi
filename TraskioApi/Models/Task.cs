using System;

namespace TraskioApi.Models;
public class Task
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
}
