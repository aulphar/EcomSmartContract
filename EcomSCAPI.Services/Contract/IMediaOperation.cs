using EcomSCAPI.Services.Dtos.Media;
using EcomSCAPI.Models;

namespace EcomSCAPI.Services.Contract
{
    public interface IMediaOperation
    {
        void UpdateMediaCollection(
            IEnumerable<UpdateMediaRequest>? mediaCollection,
            ICollection<Media>? mediaCollectionFromDb);

        Task DeleteMediaCollection(int? categoryId);

        Task DeleteMediaFromCompositionByMediaIdAsync(int compositionId, int mediaId);

        Task DeleteMediaFromCategoryByMediaIdAsync(int categoryId, int mediaId);

        Task DeleteMediaByListOfCompositionIdAsync(List<int> compositionIds);
    }
}
