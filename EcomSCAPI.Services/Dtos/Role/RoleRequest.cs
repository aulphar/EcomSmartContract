using System.ComponentModel.DataAnnotations;

namespace EcomSCAPI.Services.Dtos.Role
{
    public class RoleRequest
    {
        [Required]
        public int Id { get; set; }
    }
}
