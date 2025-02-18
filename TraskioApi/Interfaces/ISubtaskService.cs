using System.Collections.Generic;
using System.Threading.Tasks;
using Traskio.DTOs;

namespace Traskio.Interfaces
{
    public interface ISubtaskService
    {
        Task<SubtaskItemDTO?> GetSubtaskAsync(int id);
        Task<SubtaskItemDTO> CreateSubtaskAsync(CreateSubtaskDTO createSubtaskDTO);
        Task<bool> UpdateSubtaskAsync(int id, UpdateSubtaskDTO updateSubtaskDTO);
        Task<bool> DeleteSubtaskAsync(int id);
        // Task<bool> ValidateOwnershipAsync(int subtaskId, int userId);
    }
}
