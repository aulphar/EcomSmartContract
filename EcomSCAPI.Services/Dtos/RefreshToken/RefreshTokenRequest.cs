using System.ComponentModel.DataAnnotations;

namespace EcomSCAPI.Services.Dtos.RefreshToken
{
    public class RefreshTokenRequest
    {
        [Required]
        public string Token { get; set; } = string.Empty;
    }
}
