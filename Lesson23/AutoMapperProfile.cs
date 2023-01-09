using AutoMapper;
using Lesson23.Database.Entities;
using Lesson23.Models.Response;

namespace Lesson23
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Player, PlayerDto>();
            CreateMap<Team, TeamDto>().ConstructUsing(e => new TeamDto() 
            { Name = e.Name, Rate = e.Rate, CoachName = e.Coach.Name, GroupName = e.Group.Name });
            CreateMap<Coach, CoachDto>();
            CreateMap<Group, GroupDto>();
            CreateMap<Schedule, ScheduleDto>().ConstructUsing(e => new ScheduleDto()
            {
                Group = e.Group.Name,
                TeamA = e.TeamA.Name,
                TeamB = e.TeamB.Name,
                Time = e.Time
            });
        }
    }
}
