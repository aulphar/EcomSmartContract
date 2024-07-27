﻿using AutoMapper;
using EcomSCAPI.Services.Dtos.Composition;
using EcomSCAPI.Models;

namespace EcomSCAPI.Services.Automapper
{
    public class CompositionProfile : Profile
    {
        public CompositionProfile()
        {
            CreateMap<CreateCompositionRequest, Composition>().ReverseMap();

            CreateMap<UpdateCompositionRequest, Composition>()
                .ForMember(destination => destination.Id, opt => opt.Ignore())
                .ForMember(destination => destination.Sizes, opt => opt.Ignore())
                .ForMember(destination => destination.Prices, opt => opt.Ignore())
                .ForMember(destination => destination.MediaCollection, opt => opt.Ignore())
                .ForAllMembers(opts => opts.Condition((source, destination, srcMember) => srcMember is not null));

            CreateMap<Composition, CompositionResponse>().ReverseMap();

        }
    }
}
