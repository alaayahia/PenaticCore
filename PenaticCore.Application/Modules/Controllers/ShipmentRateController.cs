using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Application.Modules.Services;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Controllers
{
    
    public class ShipmentRateController : BaseApiController<ShipmentRate, ShipmentRateDTO, ShipmentRateRequestDTO, IShipmentRateService>
    {
        public ShipmentRateController(IShipmentRateService service) : base(service) { }
    }
}
