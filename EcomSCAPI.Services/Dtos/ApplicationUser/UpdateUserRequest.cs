﻿using System.ComponentModel.DataAnnotations;

namespace EcomSCAPI.Services.Dtos.ApplicationUser
{
    public record UpdateUserRequest
    {
        [StringLength(256)]
        public string? Name { get; init; }

        [EmailAddress]
        [StringLength(256)]
        public string? Email { get; init; }
    }
}
