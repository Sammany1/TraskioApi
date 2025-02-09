using System.Collections.Generic;
using System.Threading.Tasks;

namespace TraskioApi.Interfaces;
public interface IProjectService
{
    Task<IEnumerable<ProjectItemDTO>> GetAllProjects();
    Task<ProjectItemDTO?> GetProjectAsync(int id);
    Task CreateProjectAsync(ProjectItemDTO projectItemDTO);
    Task<bool> UpdateProjectAsync(int id, ProjectItemDTO projectItemDTO);
    Task<bool> DeleteProjectAsync(int id);
}
