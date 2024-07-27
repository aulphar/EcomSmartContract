using EcomSCAPI.Common.Enums;
using EcomSCAPI.Services.Dtos.APIResponse;
using EcomSCAPI.Services.Dtos.Shipping;

namespace EcomSCAPI.Services.Contract
{
    public interface IShippingOperation
    {
        Task<APIResponse<ShippingDetailsResponse>> UpdateShippingDetailsAsync(
            int shippingId, UpdateShippingDetailsRequest shippingDetailsRequest);

        Task<APIResponse<IEnumerable<ShippingDetailsResponse>>> GetAllShippingRequestsAsync(ShippingStatus? shippingStatus, int? page);
    }
}
