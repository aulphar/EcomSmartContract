using EcomSCAPI.Services.Dtos.Product;

namespace EcomSCAPI.Services.Dtos.ShoppingCart
{
    public class ShoppingCartDetailsResponse
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int CompositionId { get; set; }
        public int ProductSizeId { get; set; }
        public ProductResponse? Product { get; set; }
    }
}
