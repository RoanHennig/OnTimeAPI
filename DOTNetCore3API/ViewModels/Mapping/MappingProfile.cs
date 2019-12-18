using AutoMapper;
using DOTNETCore3.Model.Entities;
using DOTNetCore3API.ViewModels.Auth;
using DOTNetCore3API.ViewModels.BusinessSetup;

namespace DOTNetCore3API.ViewModels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Step1ViewModel, Business>();
            CreateMap<RegisterViewModel, User>();
            CreateMap<RegisterViewModel, Business>();
            CreateMap<Business, Step1ViewModel>()
                .ForMember(s => s.FirstName, map => map.MapFrom(s => s.BusinessOwner.User.FirstName))
                .ForMember(s => s.LastName, map => map.MapFrom(s => s.BusinessOwner.User.LastName));
        }
    }
}
