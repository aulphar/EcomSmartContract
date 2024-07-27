using AutoMapper;
using EcomSCAPI.Models;
using EcomSCAPI.Common.Enums;
using EcomSCAPI.Services.Dtos.APIResponse;
using EcomSCAPI.Services.Dtos.ApplicationUser;
using EcomSCAPI.Services.Dtos.BaseAddress;
using EcomSCAPI.Services.Dtos.Category;
using EcomSCAPI.Services.Dtos.Composition;
using EcomSCAPI.Services.Dtos.Composition.ComponentData;
using EcomSCAPI.Services.Dtos.Media;
using EcomSCAPI.Services.Dtos.OrderHeader;
using EcomSCAPI.Services.Dtos.OrderHeader.CustomerResponse;
using EcomSCAPI.Services.Dtos.OrderHeader.OrderDetails;
using EcomSCAPI.Services.Dtos.Payment;
using EcomSCAPI.Services.Dtos.PaymentDetails;
using EcomSCAPI.Services.Dtos.Price;
using EcomSCAPI.Services.Dtos.RefreshToken;
using EcomSCAPI.Services.Dtos.Role;
using EcomSCAPI.Services.Dtos.Shipping;
using EcomSCAPI.Services.Dtos.ShoppingCart;
using EcomSCAPI.Services.Dtos.Product;
using PayStack.Net;

namespace EcomSCAPI.Services.Automapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Category Request
            CreateMap<CreateCategoryRequest, Category>().ReverseMap();
            CreateMap<UpdateCategoryRequest, Category>()
                .ForMember(destination => destination.MediaCollection, opt => opt.Ignore())

                .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember is not null));
            CreateMap<Category, CategoryResponse>().ReverseMap();
            CreateMap<Category, CategoryLabelResponse>().ReverseMap();

            // Product Request
            
            //
            //CreateMap<UpdateProductRequest, Product>()
            //    //.ForMember(destination => destination.MediaCollection, opt => opt.Ignore())
            //    //.ForMember(destination => destination.Prices, opt => opt.Ignore())
            //    //.ForMember(destination => destination.ProductCompositions, opt => opt.Ignore())
            //    .ForMember(destination => destination.Categories, opt => opt.Ignore())
            //    .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember is not null));

            // Price Request
            CreateMap<CreatePriceRequest, Price>().ReverseMap();
            CreateMap<UpdatePriceRequest, Price>()
                .ForMember(destination => destination.Id, opt => opt.Ignore())
                .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember is not null));
            CreateMap<Price, PriceResponse>().ReverseMap();

            // Composition Data Request
            CreateMap<CreateComponentDataRequest, ComponentData>().ReverseMap();
            CreateMap<UpdateComponentDataRequest, ComponentData>()
                .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember is not null));
            CreateMap<ComponentData, ComponentDataResponse>().ReverseMap();

            // Media
            CreateMap<CreateMediaRequest, Media>().ReverseMap();
            CreateMap<UpdateMediaRequest, Media>()
                .ForMember(destination => destination.Type, opt =>
                {
                    opt.PreCondition(source =>
                    {
                        if (source.Type != null)
                            return true;
                        return false;
                    });
                })
                .ForMember(destination => destination.Id, opt => opt.Ignore())
                .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember != null));
            CreateMap<Media, MediaResponse>().ReverseMap();


            // Application User
            CreateMap<RegisterRequest, ApplicationUser>().ReverseMap();
            CreateMap<ApplicationUser, UserAuthResponse>().ReverseMap();
            CreateMap<ApplicationUser, UserDetailsResponse>().ReverseMap();
            CreateMap<ApplicationUser, UserResponse>().ReverseMap();
            CreateMap<ApplicationUser, CustomerDetailsResponse>().ReverseMap();
            CreateMap<UpdateUserRequest, ApplicationUser>()
                .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember != null));

            // Refresh Token
            CreateMap<RefreshToken, RefreshTokenResponse>().ReverseMap();

            // Roles
            CreateMap<RoleRequest, Roles>().ReverseMap();
            CreateMap<Roles, RoleResponse>().ReverseMap();

            // Payment Details
            CreateMap<PaymentDetailsRequest, PaymentDetails>().ReverseMap();
            CreateMap<PaymentDetails, PaymentDetailsResponse>().ReverseMap();
            CreateMap<TransactionInitializeResponse, APIResponse<InitializePaymentResponse>>();
            CreateMap<TransactionInitialize.Data, InitializePaymentResponse>();
            CreateMap<TransactionVerifyResponse, APIResponse<TransactionVerifyResponse>>();
            CreateMap<TransactionVerify.Data, VerifyPaymentResponse>()
                .ForMember(destination => destination.PaymentProvider, opts => opts.MapFrom(src => PaymentProvider.Paystack))
                .ForMember(destination => destination.TransactionId, opts => opts.MapFrom(src => src.Reference))
                .ForMember(destination => destination.AmountPaid, opts => opts.MapFrom(src => src.Amount));

            // Address
            CreateMap<AddressRequest, BaseAddress>()
                .ForAllMembers(opts => opts.Condition((source, destination, srcMmber) => srcMmber is not null));
            CreateMap<ShippingDetails, ShippingDetailsResponse>().ReverseMap();
            CreateMap<BaseAddress, ShippingAddressResponse>().ReverseMap();
            CreateMap<BaseAddress, AddressResponse>().ReverseMap();
            CreateMap<UpdateShippingAddressRequest, BaseAddress>()
                .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember is not null));
            CreateMap<UpdateShippingDetailsRequest, ShippingDetails>()
                .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember is not null));

            // Order Header
            CreateMap<OrderHeader, CheckoutResponse>().ReverseMap();
            CreateMap<OrderHeader, OrderResponse>().ReverseMap();
            CreateMap<OrderHeader, OrderOverviewResponse>().ReverseMap();
            CreateMap<OrderDetails, OrderDetailsResponse>().ReverseMap();
            CreateMap<Product, ProductSummaryResponse>();
            CreateMap<OrderProduct, ProductSummaryResponse>();

            // Order Purchase
            CreateMap<PurchaseDetails, PurchaseDetailsSummaryResponse>().ReverseMap();

            CreateMap<ProductSizeRequest, ProductSize>().ReverseMap();
            CreateMap<ProductSize, ProductSizeResponse>().ReverseMap();

            CreateMap<UpdateProductSizeRequest, ProductSize>()
                .ForMember(destination => destination.Id, opt => opt.Ignore())
                .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember is not null));

            CreateMap<OrderProductSize, OrderProductSizeResponse>();

            CreateMap<OrderComposition, OrderCompositionResponse>();

        }
    }
}
