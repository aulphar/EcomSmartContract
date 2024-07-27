using System.ComponentModel.DataAnnotations;

namespace EcomSCAPI.Services.Dtos.Composition
{
    public record ProductSizeRequest
    {
        [Required]
        public string? Size { get; init; }
        public int Quantity { get; init; } = 0;
    }
}
