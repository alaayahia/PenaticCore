using AutoMapper;
using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Services
{
    



    public interface IEmirateService : IServiceBase<Emirate, EmirateDTO, EmirateRequestDTO> { }

    public class EmirateService : ServiceBase<Emirate, EmirateDTO, EmirateRequestDTO>, IEmirateService
    {
        public EmirateService(IMapper mapper, IRepositoryBase<Emirate> repository) : base(mapper, repository) { }

    }
}
