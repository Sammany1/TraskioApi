namespace TraskioApi.Services;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class TaskService : ITaskService
{
    private readonly AppDbContext _context;

    public TaskService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TaskItemDTO>> GetAllTasks()
    {
        return await _context.Tasks.Select(x => new TaskItemDTO(x)).ToListAsync();
    }

    public async Task<TaskItemDTO?> GetTaskAsync(int id)
    {
        var task = await _context.Tasks.FindAsync(id);
        return task != null ? new TaskItemDTO(task) : null;
    }

    public async Task CreateTaskAsync(TaskItemDTO taskItemDTO)
    {
        var task = new Task
        {
            Title = taskItemDTO.Title,
            Description = taskItemDTO.Description,
            ProjectId = taskItemDTO.ProjectId,
            AssignedTo = taskItemDTO.AssignedTo,
            Status = taskItemDTO.Status,
            Priority = taskItemDTO.Priority,
            StartDate = taskItemDTO.StartDate,
            DueDate = taskItemDTO.DueDate,
        };
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> UpdateTaskAsync(int id, TaskItemDTO taskItemDTO)
    {
        var task = await _context.Tasks.FindAsync(id);
        if (task == null)
        {
            return false;
        }

        task.Title = taskItemDTO.Title;
        task.Description = taskItemDTO.Description;
        task.ProjectId = taskItemDTO.ProjectId;
        task.AssignedTo = taskItemDTO.AssignedTo;
        task.Status = taskItemDTO.Status;
        task.Priority = taskItemDTO.Priority;
        task.StartDate = taskItemDTO.StartDate;
        task.DueDate = taskItemDTO.DueDate;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteTaskAsync(int id)
    {
        var task = await _context.Tasks.FindAsync(id);
        if (task == null)
        {
            return false;
        }

        _context.Tasks.Remove(task);
        await _context.SaveChangesAsync();
        return true;
    }
}
