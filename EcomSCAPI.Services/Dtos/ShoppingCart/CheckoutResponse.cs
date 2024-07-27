using EcomSCAPI.Common.Enums;

namespace EcomSCAPI.Services.Dtos.ShoppingCart
{
    public class CheckoutResponse
    {
        public string? Id { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
