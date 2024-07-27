using EcomSCAPI.Services.Dtos.Composition.ComponentData;
using EcomSCAPI.Models;

namespace EcomSCAPI.Services.Contract
{
    public interface IComponentDataOperation
    {
        void UpdateComponentData(
            IEnumerable<UpdateComponentDataRequest>? compositionDataRequests,
            ICollection<ComponentData>? existingCompositionDataFromDb);

        Task DeleteProductComponents(int productId);

        Task DeleteComponentDataByComponentIdAsync(int productId, int componentId);
    }
}
