using System.Collections.Generic;
using System.Threading.Tasks;
using Traskio.DTOs;

namespace Traskio.Interfaces
{
    public interface ITodoService
    {
        Task<TodoItemDTO?> GetTodoAsync(int id);
        Task<TodoItemDTO> CreateTodoAsync(CreateTodoDTO createTodoDTO);
        Task<bool> UpdateTodoAsync(int id, UpdateTodoDTO updateTodoDTO);
        Task<bool> DeleteTodoAsync(int id);
        // Task<bool> ValidateOwnershipAsync(int todoId, int userId);
    }
}
