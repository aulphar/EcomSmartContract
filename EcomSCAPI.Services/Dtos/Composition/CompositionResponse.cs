using EcomSCAPI.Services.Dtos.Media;
using EcomSCAPI.Services.Dtos.Price;

namespace EcomSCAPI.Services.Dtos.Composition
{
    public record CompositionResponse
    {
        public int Id { get; init; }

        public string? ColorName { get; init; }

        public string? ColorCode { get; init; }

        public ICollection<ProductSizeResponse>? Sizes { get; init; }

        public ICollection<PriceResponse>? Prices { get; init; }

        public ICollection<MediaResponse>? MediaCollection { get; init; }
    }
}
