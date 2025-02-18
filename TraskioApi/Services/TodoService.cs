using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traskio.Interfaces;
using Traskio.Models;
using Traskio.DTOs;

namespace Traskio.Services
{
    public class TodoService : ITodoService
    {
        private readonly AppDbContext _context;

        public TodoService(AppDbContext context)
        {
            _context = context;
        }


        public async Task<TodoItemDTO?> GetTodoAsync(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            return todo != null ? new TodoItemDTO(todo) : null;
        }

        public async Task<TodoItemDTO> CreateTodoAsync(CreateTodoDTO createTodoDTO)
        {
            var todo = new Todo
            {
                DashboardId = createTodoDTO.DashboardId,
                Title = createTodoDTO.Title,
                Description = createTodoDTO.Description,
                Priority = createTodoDTO.Priority,
                StartDate = createTodoDTO.StartDate,
                DueDate = createTodoDTO.DueDate
            };

            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();

            return new TodoItemDTO(todo);
        }

        public async Task<bool> UpdateTodoAsync(int id, UpdateTodoDTO updateTodoDTO)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo == null)
            {
                return false;
            }

            todo.Title = updateTodoDTO.Title;
            todo.Description = updateTodoDTO.Description;
            todo.Priority = updateTodoDTO.Priority;
            todo.StartDate = updateTodoDTO.StartDate;
            todo.DueDate = updateTodoDTO.DueDate;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTodoAsync(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo == null)
            {
                return false;
            }

            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
            return true;
        }

        // public async Task<bool> ValidateOwnershipAsync(int todoId, int userId)
        // {
        //     var todo = await _context.Todos.FindAsync(todoId);
        //     return todo != null && todo.Dashboard.UserId == userId;
        // }
    }
}
