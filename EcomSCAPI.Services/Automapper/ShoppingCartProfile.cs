using AutoMapper;
using EcomSCAPI.Services.Dtos.ShoppingCart;
using EcomSCAPI.Models;

namespace EcomSCAPI.Services.Automapper
{
    public class ShoppingCartProfile : Profile
    {
        public ShoppingCartProfile()
        {
            CreateMap<AddToCartRequest, ShoppingCart>()
                .ForMember(dest => dest.CompositionId, opt => opt.MapFrom(src => src.SelectedCompositionId))
                .ForMember(dest => dest.ProductSizeId, opt => opt.MapFrom(src => src.SelectedProductSizeId));

            CreateMap<ShoppingCart, ShoppingCartDetailsResponse>().ReverseMap();
            CreateMap<ShoppingCart, AddToCartResponse>().ReverseMap();
        }
    }
}
