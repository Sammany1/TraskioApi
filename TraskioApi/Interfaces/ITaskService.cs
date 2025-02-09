using System.Collections.Generic;
using System.Threading.Tasks;

namespace TraskioApi.Interfaces;
public interface ITaskService
{
    Task<IEnumerable<TaskItemDTO>> GetAllTasks();
    Task<TaskItemDTO?> GetTaskAsync(int id);
    Task CreateTaskAsync(TaskItemDTO taskItemDTO);
    Task<bool> UpdateTaskAsync(int id, TaskItemDTO taskItemDTO);
    Task<bool> DeleteTaskAsync(int id);
}
