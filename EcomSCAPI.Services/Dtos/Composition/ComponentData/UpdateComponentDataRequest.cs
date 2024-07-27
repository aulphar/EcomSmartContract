using System.ComponentModel.DataAnnotations;

namespace EcomSCAPI.Services.Dtos.Composition.ComponentData
{
    public class UpdateComponentDataRequest
    {
        public int? Id { get; set; }

        [StringLength(20, ErrorMessage = "Data field has a maximum length of '20'")]
        public string? Data { get; set; }
    }
}
