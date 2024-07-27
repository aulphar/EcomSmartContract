using EcomSCAPI.Services.Dtos.APIResponse;
using EcomSCAPI.Services.Dtos.Product;

namespace EcomSCAPI.Services.Contract
{
    public interface IProductOperation
    {
        Task<APIResponse<IEnumerable<ProductResponse>>> GetAllProductsAsync(bool? active, bool? featured, int? categoryId, int? page);

        Task<APIResponse<ProductDetailsResponse>> GetProductByIdAsync(int productId);

        Task<APIResponse<ProductDetailsResponse>> CreateProductAsync(CreateProductRequest productRequest);

        Task<APIResponse<ProductDetailsResponse>> UpdateProductAsync(int productId, UpdateProductRequest productRequest);

        Task DeleteProductAsync(int productId);

        Task DeleteCategoryFromProductByCategoryIdAsync(int productId, int categoryId);

        Task DeleteCompositionFromProductByCompositionIdAsync(int productId, int compositionId);

        Task DeleteComponentDataFromProductByComponentIdAsync(int productId, int componentId);
    }
}