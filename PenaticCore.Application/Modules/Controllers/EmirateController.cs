using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Application.Modules.Services;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Modules.Controllers
{
    public class EmirateController : BaseApiController<Emirate, EmirateDTO, EmirateRequestDTO, IEmirateService>
    {
        public EmirateController(IEmirateService service) : base(service) { }
    }
}
