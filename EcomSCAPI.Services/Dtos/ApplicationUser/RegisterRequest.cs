using System.ComponentModel.DataAnnotations;
using EcomSCAPI.Services.Dtos.Role;

namespace EcomSCAPI.Services.Dtos.ApplicationUser
{
    /// <summary>
    /// User Register Request
    /// </summary>
    public class RegisterRequest
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public ICollection<RoleRequest>? RolesId { get; set; }
    }
}
