using System.Collections.Generic;
using System.Threading.Tasks;
using TraskioApi.DTOs;

namespace TraskioApi.Interfaces;
public interface IUserService
{
    Task<IEnumerable<UserItemDTO>> GetAllUsers();
    Task<UserItemDTO?> GetUserAsync(int id);
    Task<UserItemDTO> CreateUserAsync(CreateUserDTO createUserDTO);
    Task<bool> UpdateUserAsync(int id, UpdateUserDTO updateUserDTO);
    Task<bool> DeleteUserAsync(int id);
}
