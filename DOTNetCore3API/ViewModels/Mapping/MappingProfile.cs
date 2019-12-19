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
            CreateMap<Step2ViewModel, Business>()
                .ForPath(s => s.BusinessCategory.BusinessTypeId, map => map.MapFrom(s => s.SelectedBusinessTypeId));
            CreateMap<Business, Step2ViewModel>()
            .ForMember(s => s.SelectedBusinessTypeId, map => map.MapFrom(s => s.BusinessCategory.BusinessTypeId));


        }
    }
}
