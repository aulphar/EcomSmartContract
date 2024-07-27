using EcomSCAPI.Models;
using EcomSCAPI.Services.Dtos.Media;
using EcomSCAPI.Services.Dtos.Price;
using System.ComponentModel.DataAnnotations;
using EcomSCAPI.Services.Dtos.Category;
using EcomSCAPI.Services.Dtos.Composition;
using EcomSCAPI.Services.Dtos.Composition.ComponentData;

namespace EcomSCAPI.Services.Dtos.Product
{
    public class UpdateProductRequest
    {
        [StringLength(20, ErrorMessage = "Field has a minimum length of '2' and maximum length of '20'", MinimumLength = 2)]
        public string? Title { get; set; }

        [StringLength(100, ErrorMessage = "Field has a minimum length of 10 and maximum length of '100'", MinimumLength = 10)]
        public string? Description { get; set; }

        public bool? Active { get; set; }

        public bool? Featured { get; set; }

        public ICollection<UpdateCompositionRequest>? Compositions { get; set; }

        public ICollection<UpdateComponentDataRequest>? ComponentDataCollection { get; set; }

        public ICollection<ProductCategoryRequest>? Categories { get; set; }
    }
}
