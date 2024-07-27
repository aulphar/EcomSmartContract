using EcomSCAPI.Common.Enums;
using EcomSCAPI.Services.Dtos.APIResponse;
using EcomSCAPI.Services.Dtos.OrderHeader;
using EcomSCAPI.Services.Dtos.Shipping;

namespace EcomSCAPI.Services.Contract
{
    public interface IAdminOrderOperation
    {
        Task<APIResponse<OrderResponse>> GetOrderByIdAsync(string orderId);
        Task<APIResponse<IEnumerable<OrderOverviewResponse>>> GetOrdersAsync(OrderStatus? orderStatus, int? page);
        Task<APIResponse<UpdateOrderStatusResponse>> UpdateOrderStatusAsync(string orderId, OrderStatus orderStatus);
        Task<APIResponse<ShippingDetailsResponse>> UpdateOrderShippingDetailsAsync(
            string orderId, UpdateShippingDetailsRequest shippingDetailsRequest);
        Task<APIResponse<ShippingDetailsResponse>> GetOrderShippingDetailsAsync(string orderId);
    }
}
