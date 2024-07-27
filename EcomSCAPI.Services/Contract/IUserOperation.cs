using EcomSCAPI.Common.Enums;
using EcomSCAPI.Services.Dtos.APIResponse;
using EcomSCAPI.Services.Dtos.ApplicationUser;
using EcomSCAPI.Services.Dtos.BaseAddress;
using EcomSCAPI.Services.Dtos.Role;

namespace EcomSCAPI.Services.Contract
{
    public interface IUserOperation
    {
        Task<APIResponse<IEnumerable<UserResponse>>> GetUsersAsync(
            int? roleId,
            bool? active, 
            bool? deleted, 
            int? page);
        Task<APIResponse<UserDetailsResponse>> GetUserByIdAsync(string userId);
        Task<APIResponse<UserDetailsResponse>> UpdateUserDetailsAsync(string userId, UpdateUserRequest updateUserRequest);
        Task <APIResponse<AddressResponse>>UpdateAddressAsync(string userId, AddressRequest updateAddressRequest);
        Task DeleteAccountAsync(string userId);
        Task LockUnlockUserAsync(string userId, AccountAction accountAction);
        Task <APIResponse<UserAuthResponse>> DeleteRoleFromUserAsync(string userId, int roleId);
        Task<APIResponse<UserAuthResponse>> UpdateUserRoleUserAsync(string userId, int roleId);
    }
}
