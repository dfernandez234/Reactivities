using AutoMapper;
using Reactivities.Contracts.Activities;
using Reactivities.Domain.Entities;

namespace Reactivities.API.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig() { 
            CreateMap<Activity, CreateRequest>().ReverseMap();
            CreateMap<Activity, EditRequest>().ReverseMap();

            CreateMap<Activity, GetActivityResponse>().ForMember(d => d.HostUsername, o => o.MapFrom(s => s.Attendees
                .FirstOrDefault(x => x.IsHost).AppUser.UserName));

            CreateMap<ActivityAttendee, Reactivities.Contracts.Users.Profile>()
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.AppUser.DisplayName))
                .ForMember(d => d.Username, o => o.MapFrom(s => s.AppUser.UserName))
                .ForMember(d => d.Bio, o => o.MapFrom(s => s.AppUser.Bio));
        }
    }
}
