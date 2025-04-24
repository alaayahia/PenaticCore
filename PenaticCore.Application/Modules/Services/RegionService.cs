using AutoMapper;
using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Services
{


    public interface IRegionService : IServiceBase<Region, RegionDTO, RegionRequestDTO> { }

    public class RegionService : ServiceBase<Region, RegionDTO, RegionRequestDTO>, IRegionService
    {
        public RegionService(IMapper mapper, IRepositoryBase<Region> repository) : base(mapper, repository) { }

    }
}
