using AutoMapper;
using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Services
{
    

    public interface IShipmentRateService : IServiceBase<ShipmentRate, ShipmentRateDTO, ShipmentRateRequestDTO> { }

    public class ShipmentRateService : ServiceBase<ShipmentRate, ShipmentRateDTO, ShipmentRateRequestDTO>, IShipmentRateService
    {
        public ShipmentRateService(IMapper mapper, IRepositoryBase<ShipmentRate> repository) : base(mapper, repository) { }

    }
}
