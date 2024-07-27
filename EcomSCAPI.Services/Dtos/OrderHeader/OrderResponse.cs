using EcomSCAPI.Common.Enums;
using EcomSCAPI.Services.Dtos.OrderHeader.CustomerResponse;
using EcomSCAPI.Services.Dtos.PaymentDetails;
using EcomSCAPI.Services.Dtos.Shipping;

namespace EcomSCAPI.Services.Dtos.OrderHeader
{
    public record OrderResponse
    {
        public string? Id { get; init; }
        public OrderStatus? OrderStatus { get; init; }

        public DateTime? OrderDate { get; init; }
        public DateTime? CancelledDate { get; init; }

        public PaymentDetailsResponse? PaymentDetails { get; init; }
        public ShippingDetailsResponse? ShippingDetails { get; init; }
        public ICollection<OrderDetailsResponse>? OrderDetails { get; init; }
        public CustomerDetailsResponse? ApplicationUser { get; init; }
    }
}
