using EcomSCAPI.Common.Utilities;
using EcomSCAPI.Common.Enums;
using EcomSCAPI.Services.Dtos.APIResponse;
using EcomSCAPI.Services.Dtos.Payment;
using EcomSCAPI.Services.Dtos.ShoppingCart;

namespace EcomSCAPI.Services.Contract
{
    public interface IShoppingCartOperation
    {
        Task<APIResponse<AddToCartResponse>> AddProductToCartAsync(AddToCartRequest addToCartRequest);

        Task<APIResponse<ShoppingCartListResponse>> GetAllItemsInCartAsync(Currency currency = Defaults.DefaultCurrency);

        Task<APIResponse<ShoppingCartDetailsResponse>> GetItemInCartAsync(int shoppingCartId);

        Task<APIResponse<ShoppingCartUpdateResponse>> IncreaseItemInCartAsync(int shoppingCartId, ShoppingCartRequest? shoppingCartRequest);

        Task<APIResponse<ShoppingCartUpdateResponse>> DecreaseItemInCartAsync(int shoppingCartId, ShoppingCartRequest? shoppingCartRequest);

        Task<APIResponse<ShoppingCartUpdateResponse>> DeleteItemInCartAsync(int shoppingCartId, Currency currency = Defaults.DefaultCurrency);

        APIResponse<InitializePaymentResponse> InitializeTransactionForCheckout(
            InitializePaymentRequest initializePaymentRequest);

        APIResponse<VerifyPaymentResponse> VerifyTransaction(VerifyPaymentRequest verifyPaymentRequest);

        Task<APIResponse<CheckoutResponse>> CheckoutAsync(CheckoutRequest checkoutRequest);
    }
}
