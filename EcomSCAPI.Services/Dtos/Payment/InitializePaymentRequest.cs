﻿using EcomSCAPI.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace EcomSCAPI.Services.Dtos.Payment
{
    public record InitializePaymentRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; init; } = string.Empty;
        public required decimal Amount { get; init; }
        public Currency Currency { get; init; }
        public PaymentProvider PaymentProvider { get; init; }
    }
}
