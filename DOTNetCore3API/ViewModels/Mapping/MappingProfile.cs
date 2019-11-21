using AutoMapper;
using DOTNETCore3.Model.Entities;
using DOTNetCore3API.ViewModels.BusinessSetup;

namespace DOTNetCore3API.ViewModels.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Business, Step1ViewModel>()
                .ForMember(s => s.FirstName, map => map.MapFrom(s => s.OwnerFirstName))
                .ForMember(s => s.LastName, map => map.MapFrom(s => s.OwnerLastName));
        }
    }
}
