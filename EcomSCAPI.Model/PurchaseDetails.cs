using EcomSCAPI.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomSCAPI.Models
{
    public class PurchaseDetails
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public decimal? ProductAmountAtPurchase { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal? DiscountAmount { get; set; }

        [Required]
        public Currency? Currency { get; set; }

        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;

        public string? ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
