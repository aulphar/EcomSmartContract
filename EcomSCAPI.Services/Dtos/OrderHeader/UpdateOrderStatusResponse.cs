using EcomSCAPI.Common.Enums;

namespace EcomSCAPI.Services.Dtos.OrderHeader
{
    public record UpdateOrderStatusResponse
    {
        public string? OrderId { get; init; }
        public OrderStatus OrderStatus { get; init; }
    }
}
