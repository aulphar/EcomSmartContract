using EcomSCAPI.Services.Dtos.Price;
using EcomSCAPI.Models;
using EcomSCAPI.Services.Dtos.Media;

namespace EcomSCAPI.Services.Contract
{
    public interface IPriceOperation
    {
        Task DeletePricesByListOfCompositionIdAsync(List<int> compositionIds);
        void UpdatePrice(IEnumerable<UpdatePriceRequest>? priceCollection, ICollection<Price>? pricesFromDb);
        Task DeletePriceFromCompositionByPriceIdAsync(int compositionId, int priceId);
        Task ResetDiscountOfCompositionPriceByPriceIdAsync(int compositionId, int priceId);
    }
}
