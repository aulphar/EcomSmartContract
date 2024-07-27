using EcomSCAPI.Services.Dtos.Category;
using EcomSCAPI.Services.Dtos.Composition;

namespace EcomSCAPI.Services.Dtos.Product
{
    public class ProductResponse
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public bool Active { get; set; }

        public bool? Featured { get; set; }

        public ICollection<CompositionResponse>? Compositions { get; set; }

        public ICollection<CategoryLabelResponse>? Categories { get; set; }
    }
}
