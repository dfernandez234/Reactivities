using AutoMapper;
using Reactivities.Contracts.Activities;
using Reactivities.Contracts.Attendees;
using Reactivities.Contracts.Photos;
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

            CreateMap<ActivityAttendee, AttendeeDTO>()
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.AppUser.DisplayName))
                .ForMember(d => d.Username, o => o.MapFrom(s => s.AppUser.UserName))
                .ForMember(d => d.Bio, o => o.MapFrom(s => s.AppUser.Bio))
                .ForMember(d => d.Image, o => o.MapFrom(s => s.AppUser.Photos.FirstOrDefault(x => x.IsMain).Url));

            CreateMap<AppUser, Reactivities.Contracts.Users.Profile>()
                .ForMember(d => d.Image, o => o.MapFrom(s => s.Photos.FirstOrDefault(x => x.IsMain).Url));

            CreateMap<Photo, GetPhoto>().ReverseMap();
        }
    }
}
