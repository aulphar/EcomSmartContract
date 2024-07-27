using System.ComponentModel.DataAnnotations;
using EcomSCAPI.Services.Dtos.BaseAddress;

namespace EcomSCAPI.Services.Dtos.ShoppingCart
{
    public class CheckoutRequest
    {
        [Required]
        public required PaymentDetailsRequest PaymentDetailsRequest { get; set; }
        [Required]
        public required AddressRequest ShippingAddress { get; set; }
    }
}
