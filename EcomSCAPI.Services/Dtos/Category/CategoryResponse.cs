using EcomSCAPI.Services.Dtos.Media;

namespace EcomSCAPI.Services.Dtos.Category
{
    /// <summary>
    /// Category Response object
    /// </summary>
    public record CategoryResponse
    {
        public int Id { get; init; }
        public string? Title { get; init; }
        /// <summary>
        /// Category Medias
        /// </summary>
        public ICollection<MediaResponse>? MediaCollection { get; init; }

        public bool? Active { get; init; }
        public bool? Featured { get; init; }
    }
}
