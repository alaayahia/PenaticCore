using AutoMapper;
using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Services
{
   


    public interface IShipmentServiceService : IServiceBase<ShipmentService, ShipmentServiceDTO, ShipmentServiceRequestDTO> { }

    public class ShipmentServiceService : ServiceBase<ShipmentService, ShipmentServiceDTO, ShipmentServiceRequestDTO>, IShipmentServiceService
    {
        public ShipmentServiceService(IMapper mapper, IRepositoryBase<ShipmentService> repository) : base(mapper, repository) { }

    }
}
