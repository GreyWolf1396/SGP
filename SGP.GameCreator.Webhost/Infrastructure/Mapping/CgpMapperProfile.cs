using AutoMapper;
using Microsoft.OpenApi.Extensions;
using SGP.Domain;
using SGP.GameCreator.Webhost.Models.BaseModels;
using SGP.GameCreator.Webhost.Models.GameModels;
using SGP.GameCreator.Webhost.Models.PhaseModels;

namespace SGP.GameCreator.Webhost.Infrastructure.Mapping
{
    public class CgpMapperProfile : Profile
    {
        public CgpMapperProfile()
        {
            CreateMap<BaseObject, BaseObjectModel>()
                .ForMember(dest => dest.Id, cfg => cfg.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, cfg => cfg.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, cfg => cfg.MapFrom(src => src.Description))
                .ReverseMap()
                .ForMember(dest => dest.Id, cfg => cfg.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, cfg => cfg.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, cfg => cfg.MapFrom(src => src.Description));

            CreateMap<Phase, PhaseModel>()
                .IncludeBase<BaseObject, BaseObjectModel>()
                .ForMember(dest => dest.IsMandatory, cfg => cfg.MapFrom(src => src.IsMandatory))
                .ForMember(dest => dest.Number, cfg => cfg.MapFrom(src => src.Number))
                .ForMember(dest => dest.Type, cfg => cfg.MapFrom(src => src.Type.ToString()));

            CreateMap<Game, GameModel>()
                .IncludeBase<BaseObject,BaseObjectModel>()
                .ReverseMap()
                .IncludeBase<BaseObjectModel, BaseObject>();
        }
    }
}
