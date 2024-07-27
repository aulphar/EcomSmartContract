using EcomSCAPI.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace EcomSCAPI.Services.Dtos.Price
{
    /// <summary>
    /// Create Price Request
    /// </summary>
    public class CreatePriceRequest
    {
        [Required]
        public decimal? Amount { get; set; }
        [Required]
        public Currency? Currency { get; set; }

        /// <summary>
        /// indicate if price is discounted
        /// </summary>
        public decimal? DiscountAmount { get; set; }
    }
}
