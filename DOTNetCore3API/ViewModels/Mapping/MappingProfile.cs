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
        }
    }
}
