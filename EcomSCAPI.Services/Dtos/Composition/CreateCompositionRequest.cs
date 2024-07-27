using System.ComponentModel.DataAnnotations;
using EcomSCAPI.Services.Dtos.Media;
using EcomSCAPI.Services.Dtos.Price;

namespace EcomSCAPI.Services.Dtos.Composition
{
    public class CreateCompositionRequest
    {
        [Required]
        [StringLength(20, ErrorMessage = "Field has a maximum length of '20'")]
        public required string ColorName { get; init; }

        [Required]
        public required string ColorCode { get; init; }

        public ICollection<ProductSizeRequest>? Sizes { get; init; }

        [Required]
        public ICollection<CreatePriceRequest>? Prices { get; init; }

        public ICollection<CreateMediaRequest>? MediaCollection { get; init; }
    }
}
