using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Application.Modules.Services;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Controllers
{
 


    public class ShipmentDetailController : BaseApiController<ShipmentDetail, ShipmentDetailDTO, ShipmentDetailRequestDTO, IShipmentDetailService>
    {
        public ShipmentDetailController(IShipmentDetailService service) : base(service) { }
    }
}
