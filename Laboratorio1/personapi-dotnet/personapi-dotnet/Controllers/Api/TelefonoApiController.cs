using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Services.Interfaces;

namespace personapi_dotnet.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelefonoApiController : ControllerBase
    {
        private readonly ITelefonoService _service;

        public TelefonoApiController(ITelefonoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{num}")]
        public IActionResult GetById(string num)
        {
            var tel = _service.GetById(num);
            return tel == null ? NotFound() : Ok(tel);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Telefono tel)
        {
            _service.Add(tel);
            return CreatedAtAction(nameof(GetById), new { num = tel.Num }, tel);
        }

        [HttpPut("{num}")]
        public IActionResult Update(string num, [FromBody] Telefono tel)
        {
            if (num != tel.Num) return BadRequest();
            _service.Update(tel);
            return NoContent();
        }

        [HttpDelete("{num}")]
        public IActionResult Delete(string num)
        {
            _service.Delete(num);
            return NoContent();
        }
    }
}
