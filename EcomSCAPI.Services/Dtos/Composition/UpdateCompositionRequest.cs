using System.ComponentModel.DataAnnotations;
using EcomSCAPI.Services.Dtos.Media;
using EcomSCAPI.Services.Dtos.Price;

namespace EcomSCAPI.Services.Dtos.Composition
{
    public class UpdateCompositionRequest
    {
        public int? Id { get; set; }

        [StringLength(20, ErrorMessage = "Field has a maximum length of '20'")]
        public string? ColorName { get; set; }

        public string? ColorCode { get; set; }

        public ICollection<UpdateProductSizeRequest>? Sizes { get; set; }

        public ICollection<UpdatePriceRequest>? Prices { get; set; }

        public ICollection<UpdateMediaRequest>? MediaCollection { get; set; }
    }
}
