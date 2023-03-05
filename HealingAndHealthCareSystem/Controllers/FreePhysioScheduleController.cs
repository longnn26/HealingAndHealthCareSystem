using Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;

namespace HealingAndHealthCareSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreePhysioScheduleController : ControllerBase
    {
        private readonly IFreePhysioScheduleService _freePhysioScheduleservice;
        private readonly IFreePhysioScheduleService _freePhysioScheduleservice1;
        public FreePhysioScheduleController(IFreePhysioScheduleService freePhysioScheduleService, IFreePhysioScheduleService freePhysioScheduleService1)
        {
            _freePhysioScheduleservice = freePhysioScheduleService;
            _freePhysioScheduleservice1 = freePhysioScheduleService1;
        }
        //[Authorize(AuthenticationSchemes = "Bearer")]
        [HttpPost]
        public IActionResult Post([FromBody] FreePhysioScheduleCreateModel model)
        {
            var result = _freePhysioScheduleservice.Add(model);
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }

        //[Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet]
        public IActionResult Get()
        {
            var result = _freePhysioScheduleservice.GetAll();
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var result = _freePhysioScheduleservice.Get(id);
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            var result = _freePhysioScheduleservice.Delete(id);
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }
        [HttpPut]
        public IActionResult Update(FreePhysioScheduleUpdateModel model)
        {
            var result = _freePhysioScheduleservice.Update(model);
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }

    }
}
