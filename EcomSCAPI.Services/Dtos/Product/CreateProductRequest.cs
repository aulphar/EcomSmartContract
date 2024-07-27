using EcomSCAPI.Models;
using EcomSCAPI.Services.Dtos.Media;
using EcomSCAPI.Services.Dtos.Price;
using EcomSCAPI.Services.Dtos.Rating;
using System.ComponentModel.DataAnnotations;
using EcomSCAPI.Services.Dtos.Category;
using EcomSCAPI.Services.Dtos.Composition;
using EcomSCAPI.Services.Dtos.Composition.ComponentData;

namespace EcomSCAPI.Services.Dtos.Product
{
    public record CreateProductRequest
    {
        [Required]
        [StringLength(20, ErrorMessage = "Field has a minimum length of '2' and maximum length of '20'", MinimumLength = 2)]
        public string? Title { get; init; }

        [Required]
        [StringLength(100, ErrorMessage = "Field has a minimum length of 10 and maximum length of '100'", MinimumLength = 10)]
        public string? Description { get; init; }

        public bool Active { get; init; } = true;

        public bool? Featured { get; init; }

        public ICollection<CreateCompositionRequest>? Compositions { get; init; }
        
        public ICollection<CreateComponentDataRequest>? MaterialsAndDetails { get; set; }

        public ICollection<ProductCategoryRequest>? Categories { get; init; }
    }
}
