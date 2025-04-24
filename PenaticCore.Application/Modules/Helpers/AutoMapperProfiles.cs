using AutoMapper;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Emirate, EmirateDTO>().ReverseMap();
            CreateMap<Emirate, EmirateRequestDTO>().ReverseMap();

            CreateMap<Region, RegionDTO>().ReverseMap();
            CreateMap<Region, RegionRequestDTO>().ReverseMap();
        }
            

       
    }
}
