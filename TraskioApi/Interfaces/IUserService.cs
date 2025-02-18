using System.Collections.Generic;
using System.Threading.Tasks;
using Traskio.DTOs;
using Traskio.Models;

namespace Traskio.Interfaces;
public interface IUserService
{
    Task<IEnumerable<UserItemDTO>> GetAllUsers();
    Task<UserItemDTO?> GetUserAsync(int id);
    Task<UserItemDTO> CreateUserAsync(CreateUserDTO createUserDTO);
    Task<bool> UpdateUserAsync(int id, UpdateUserDTO updateUserDTO);
    Task<bool> DeleteUserAsync(int id);
    Task<UserItemDTO?> GetUserByEmailAsync(string email);
    Task<User?> GetFullUserByEmailAsync(string email); 
    // Task<UserItemDTO?> ValidateUser(string email, string password);
}
