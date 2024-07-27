using EcomSCAPI.Common.Enums;

namespace EcomSCAPI.Services.Dtos.ShoppingCart
{
    public record CartTotalResponse
    {
        public decimal TotalAmount { get; init; }
        public Currency CurrencyToBePaidIn { get; init; }
    }
}
