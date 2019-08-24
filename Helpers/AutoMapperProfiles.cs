using AutoMapper;
using PresentationCreatorWeb.Data.Models;
using PresentationCreatorWeb.Dtos;

namespace PresentationCreatorWeb.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForDetailedDto>();
        }
    }
}