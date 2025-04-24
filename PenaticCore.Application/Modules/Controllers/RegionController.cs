using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.DTO.RequestDTO;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Application.Modules.Services;
using PenaticCore.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace PenaticCore.Application.Modules.Controllers
{
    

    public class RegionController : BaseApiController<Region, RegionDTO, RegionRequestDTO, IRegionService>
    {
        public RegionController(IRegionService service) : base(service) { }

        [HttpGet("GetRegionByEmirate")]
        public async Task<IActionResult> GetRegionByEmirate(string emirateId)
        {
            var result = await ServiceObj.GetRegionByEmirate(emirateId);
            return Ok(result);
        }
    }
}
