using EcomSCAPI.Common.Enums;

namespace EcomSCAPI.Services.Dtos.Payment
{
    public record VerifyPaymentRequest
    {
        public required string Reference { get; init; }
        public Currency Currency { get; init; }
        public PaymentProvider PaymentProvider { get; init; }
    }
}
