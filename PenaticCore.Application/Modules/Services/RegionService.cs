using AutoMapper;
using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Services
{


    public interface IRegionService : IServiceBase<Region, RegionDTO, RegionRequestDTO> {
    
        Task<IEnumerable<RegionDTO>> GetRegionByEmirate(string  emirateId);
    }

    public class RegionService : ServiceBase<Region, RegionDTO, RegionRequestDTO>, IRegionService
    {
        private readonly IRepositoryBase<Region> _repository;
        private readonly IMapper _mapper;
        public RegionService(IMapper mapper, IRepositoryBase<Region> repository) : base(mapper, repository) {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RegionDTO>> GetRegionByEmirate(string emirateId)
        {
            var AcctYears = await _repository.WhereAsync(s => s.EmirateId == emirateId);
            var mappedResult = AcctYears.Select(_mapper.Map<RegionDTO>).ToList();
            return mappedResult;
        }
    }
}
