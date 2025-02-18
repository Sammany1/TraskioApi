using System.Collections.Generic;
using System.Threading.Tasks;
using Traskio.DTOs;

namespace Traskio.Interfaces
{
    public interface IDashboardService
    {
        Task<DashboardItemDTO?> GetDashboardAsync(int id);
        Task<DashboardItemDTO> CreateDashboardAsync(CreateDashboardDTO createDashboardDTO);
        Task<bool> UpdateDashboardAsync(int id, UpdateDashboardDTO updateDashboardDTO);
        Task<bool> DeleteDashboardAsync(int id);
        Task<IEnumerable<DashboardItemDTO>> GetUserDashboardsAsync(int userId);
        // Task<bool> ValidateOwnershipAsync(int dashboardId, int userId);
    }
}
