﻿using AutoMapper;
using HR_Management.Extensions;
using HR_Management.Resources.Location;

namespace HR_Management.Mapping.Location
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<CreateLocationResource, Domain.Models.Location>()
                .ForMember(x => x.Address, opt => opt.MapFrom(src => src.Address.RemoveSpaceCharacter()))
                .ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name.RemoveSpaceCharacter()));

            CreateMap<LocationResource, Domain.Models.Location>()
                .ForMember(x => x.Address, opt => opt.MapFrom(src => src.Address.RemoveSpaceCharacter()))
                .ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name.RemoveSpaceCharacter()));

            CreateMap<UpdateLocationResource, Domain.Models.Location>()
                .ForMember(x => x.Address, opt => opt.MapFrom(src => src.Address.RemoveSpaceCharacter()))
                .ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name.RemoveSpaceCharacter()));
        }
    }
}
