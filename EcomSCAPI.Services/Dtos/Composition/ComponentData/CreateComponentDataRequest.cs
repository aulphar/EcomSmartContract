using EcomSCAPI.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace EcomSCAPI.Services.Dtos.Composition.ComponentData
{
    public class CreateComponentDataRequest
    {
        public ComponentType Type { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Data field has a maximum length of '20'")]
        public string? Data { get; set; }
    }
}