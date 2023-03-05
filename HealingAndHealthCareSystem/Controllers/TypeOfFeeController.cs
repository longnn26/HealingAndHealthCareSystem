using Data.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;

namespace HealingAndHealthCareSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TypeOfFeeController : ControllerBase
    {
        private readonly ITypeOfFeeService _typeOfFeeservice;
        private readonly ITypeOfFeeService _typeOfFeeservice1;
        public TypeOfFeeController(ITypeOfFeeService typeOfFeeService, ITypeOfFeeService typeOfFeeService1)
        {
            _typeOfFeeservice = typeOfFeeService;
            _typeOfFeeservice1 = typeOfFeeService1;
        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Post([FromBody] TypeOfFeeCreateModel model)
        {
            var result = _typeOfFeeservice.Add(model);
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }

        //[Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet]
        public IActionResult Get()
        {
            var result = _typeOfFeeservice.GetAll();
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var result = _typeOfFeeservice.Get(id);
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            var result = _typeOfFeeservice.Delete(id);
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }
        [HttpPut]
        public IActionResult Update(TypeOfFeeUpdateModel model)
        {
            var result = _typeOfFeeservice.Update(model);
            if (result.Succeed) return Ok(result.Data);
            return BadRequest(result.ErrorMessage);
        }

    }
}
