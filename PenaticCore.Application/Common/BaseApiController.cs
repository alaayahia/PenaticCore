using Microsoft.AspNetCore.Mvc;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Domain.Models;
using PenaticCore.Infrastructure.Helpers;

namespace PenaticCore.Application.Common
{
    public interface IBaseApiController<T, TDTO, TRequestDTO, TService>
   where T : EntityBase where TDTO : BaseDTO where TService : IServiceBase<T, TDTO, TRequestDTO>
    {
        Task<IActionResult> GetSingleAsync([FromQuery] string id);
        Task<IActionResult> GetAllAsync();
        Task<IActionResult> AddAsync(TRequestDTO dTO);
        


    }
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseApiController<T, TDTO, TRequestDTO, TService> : ControllerBase, IBaseApiController<T, TDTO, TRequestDTO, TService>
                          where T : EntityBase where TDTO : BaseDTO where TService : IServiceBase<T, TDTO, TRequestDTO>

    {
        private readonly TService _service;
        protected readonly TService ServiceObj;
        protected BaseApiController(TService service)
        {
            _service = service;
            ServiceObj = service;

        }

        //Actions
        [HttpGet("ByEntity")]
        public async Task<IActionResult> GetSingleAsync([FromQuery] string id)
        {
            var result = await _service.SingleAsync(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _service.AllAsync();
            return Ok(result);
        }
        [HttpPost]
        public virtual async Task<IActionResult> AddAsync([FromBody] TRequestDTO tDTO)
        {
            var result = await _service.AddAsync(tDTO);
            var response = new ResponseModel<TDTO>(data: result);
            return Ok(response);

        }
       
        //Actions
    }
}
