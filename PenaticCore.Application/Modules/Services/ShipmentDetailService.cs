using AutoMapper;
using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Services
{
     


    public interface IShipmentDetailService : IServiceBase<ShipmentDetail, ShipmentDetailDTO, ShipmentDetailRequestDTO> { }

    public class ShipmentDetailService : ServiceBase<ShipmentDetail, ShipmentDetailDTO, ShipmentDetailRequestDTO>, IShipmentDetailService
    {
        public ShipmentDetailService(IMapper mapper, IRepositoryBase<ShipmentDetail> repository) : base(mapper, repository) { }

    }
}
