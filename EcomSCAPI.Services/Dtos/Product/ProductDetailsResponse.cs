using EcomSCAPI.Services.Dtos.Category;
using EcomSCAPI.Services.Dtos.Composition;
using EcomSCAPI.Services.Dtos.Composition.ComponentData;
using EcomSCAPI.Models;
using EcomSCAPI.Services.Dtos.Media;
using EcomSCAPI.Services.Dtos.Price;

namespace EcomSCAPI.Services.Dtos.Product
{
    public class ProductDetailsResponse
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public bool Active { get; set; }

        public bool? Featured { get; set; }

        public ICollection<CompositionResponse>? Compositions { get; set; }

        public ICollection<ComponentDataResponse>? MaterialsAndDetails { get; set; }

        public ICollection<CategoryLabelResponse>? Categories { get; set; }
    }
}
