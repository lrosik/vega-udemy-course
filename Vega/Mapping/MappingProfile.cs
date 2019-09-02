using AutoMapper;
using Vega.DTOs;
using Vega.Models;

namespace Vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeDto>();
            CreateMap<Model, ModelDto>();
            CreateMap<Feature, FeatureDto>();
        }
    }
}