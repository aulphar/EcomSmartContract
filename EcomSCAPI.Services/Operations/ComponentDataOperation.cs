using AutoMapper;
using EcomSCAPI.DataAccess.Contract;
using EcomSCAPI.Services.Contract;
using EcomSCAPI.Services.Dtos.Composition.ComponentData;
using EcomSCAPI.Models;

namespace EcomSCAPI.Services.Operations
{
    public class ComponentDataOperation : IComponentDataOperation
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ComponentDataOperation(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task DeleteComponentDataByComponentIdAsync(int productId, int componentId)
        {
            ComponentData componentDataToDelete = await _unitOfWork.ComponentData
                .GetFirstOrDefault(
                componentData => componentData.Id == componentId
                && componentData.ProductId == productId)
                ?? throw new Exception("No composition data available for this composition");

            _unitOfWork.ComponentData.Remove(componentDataToDelete);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteProductComponents(int productId)
        {
            IEnumerable<ComponentData>? componentDataCollection = await _unitOfWork.ComponentData.GetAll(
                composition => composition.Id == productId);

            if (componentDataCollection is not null && componentDataCollection.Any())
            {
                _unitOfWork.ComponentData.RemoveRange(componentDataCollection);
            }
        }

        public void UpdateComponentData(
            IEnumerable<UpdateComponentDataRequest>? componentDataRequests,
            ICollection<ComponentData>? existingcomponentDataFromDb)
        {
            if (componentDataRequests is not null && componentDataRequests.Any())
            {
                existingcomponentDataFromDb ??= new List<ComponentData>();
                foreach (var componentDataRequest in componentDataRequests)
                {
                    ComponentData? existingcomponentData = existingcomponentDataFromDb?.FirstOrDefault(em => em.Id == componentDataRequest.Id);
                    if (existingcomponentData != null)
                    {
                        _mapper.Map(componentDataRequest, existingcomponentData);
                    }
                    else
                    {
                        ComponentData newcomponentData = _mapper.Map<ComponentData>(componentDataRequest);
                        existingcomponentDataFromDb?.Add(newcomponentData);
                    }
                }
            }
        }
    }
}
