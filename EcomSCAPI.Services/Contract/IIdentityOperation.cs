using EcomSCAPI.Models;
using EcomSCAPI.Common.Enums;
using EcomSCAPI.Services.Dtos.ApplicationUser;
using EcomSCAPI.Services.Dtos.RefreshToken;
using EcomSCAPI.Services.Dtos.Role;

namespace EcomSCAPI.Services.Contract
{
    public interface IIdentityOperation
    {
        Task<UserAuthResponse> Register(RegisterRequest registerRequest);
        Task<UserAuthResponse> Login(LoginRequest loginRequest);
        Task<UserAuthResponse> RefreshToken(RefreshTokenRequest refreshTokenRequest);
        Task<ApplicationUser> GetLoggedInUserAsync();
        Task<IEnumerable<RoleResponse>> GetApplicationRoles();
        Task<ApplicationUser?> GetUserWithEmail(string? email);
    }
}
