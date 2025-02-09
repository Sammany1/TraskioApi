using System;
using TraskioApi.Models;
public class ProjectItemDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int? OwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public ProjectItemDTO() { }
    public ProjectItemDTO(Project project) =>
        (Id, Name, Description, OwnerId, CreatedAt, UpdatedAt) = (project.Id, project.Name, project.Description, project.OwnerId, project.CreatedAt, project.UpdatedAt);
}
