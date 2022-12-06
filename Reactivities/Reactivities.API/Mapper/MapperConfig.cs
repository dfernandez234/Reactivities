using AutoMapper;
using Reactivities.Contracts.Activities;
using Reactivities.Domain.Entities.Activity;

namespace Reactivities.API.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig() { 
            CreateMap<Activity, GetActivityResponse>().ReverseMap();
            CreateMap<Activity, CreateRequest>().ReverseMap();
            CreateMap<Activity, EditRequest>().ReverseMap();    
        }
    }
}
