using EcomSCAPI.Common.Enums;
using EcomSCAPI.Services.Dtos.APIResponse;
using EcomSCAPI.Services.Dtos.OrderHeader;
using EcomSCAPI.Services.Dtos.Shipping;

namespace EcomSCAPI.Services.Contract
{
    public interface ICustomerOrderOperation
    {
        Task<APIResponse<OrderResponse>> GetOrderByIdAsync(string orderId);

        Task<APIResponse<IEnumerable<OrderOverviewResponse>>> GetOrdersAsync(OrderStatus? orderStatus, int? page);

        Task<APIResponse<UpdateOrderStatusResponse>> CancelOrderAsync(string orderId);

        Task<APIResponse<ShippingDetailsResponse>> UpdateOrderShippingAddressAsync(
            string orderId, UpdateShippingAddressRequest shippingAddressRequest);
    }
}
