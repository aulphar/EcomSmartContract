using EcomSCAPI.Models;
using EcomSCAPI.Services.Dtos.Price;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcomSCAPI.Services.Dtos.Composition;

namespace EcomSCAPI.Services.Contract
{
    public interface IProductSizeOperation
    {
        Task DeleteSizeByListOfCompositionIdAsync(List<int> compositionIds);
        Task DeleteSizeFromCompositionBySizeIdAsync(int compositionId, int sizeId);
        void UpdateProductSize(IEnumerable<UpdateProductSizeRequest>? productSizeRequests,
            ICollection<ProductSize>? existingProductSizesFromDb);
    }
}
