using System.Threading.Tasks;
using Traskio.DTOs;

namespace Traskio.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseDTO?> LoginAsync(LoginDTO loginDTO);
        Task<AuthResponseDTO?> RegisterAsync(CreateUserDTO registerDTO);
    }
}
