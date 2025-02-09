namespace TraskioApi.Services;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ProjectService : IProjectService
{
    private readonly AppDbContext _context;

    public ProjectService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ProjectItemDTO>> GetAllProjects()
    {
        return await _context.Projects.Select(x => new ProjectItemDTO(x)).ToListAsync();
    }

    public async Task<ProjectItemDTO?> GetProjectAsync(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        return project != null ? new ProjectItemDTO(project) : null;
    }

    public async Task CreateProjectAsync(ProjectItemDTO projectItemDTO)
    {
        var project = new Project
        {
            Name = projectItemDTO.Name,
            Description = projectItemDTO.Description,
            OwnerId = projectItemDTO.OwnerId,
        };
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> UpdateProjectAsync(int id, ProjectItemDTO projectItemDTO)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
        {
            return false;
        }

        project.Name = projectItemDTO.Name;
        project.Description = projectItemDTO.Description;
        project.OwnerId = projectItemDTO.OwnerId;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteProjectAsync(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
        {
            return false;
        }

        _context.Projects.Remove(project);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<UserItemDTO> CreateUserAsync(CreateUserDTO createUserDTO)
    {
        var user = new User
        {
            Username = createUserDTO.Username,
            Password = HashPassword(createUserDTO.Password), // Hash password before storing
            Email = createUserDTO.Email,
            CreatedAt = DateTime.UtcNow
        };
        
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return new UserItemDTO(user);
    }
}
