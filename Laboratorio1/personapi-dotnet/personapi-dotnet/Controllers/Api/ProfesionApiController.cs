using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Services.Interfaces;

namespace personapi_dotnet.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfesionApiController : ControllerBase
    {
        private readonly IProfesionService _service;

        public ProfesionApiController(IProfesionService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var p = _service.GetById(id);
            return p == null ? NotFound() : Ok(p);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Profesion profesion)
        {
            _service.Add(profesion);
            return CreatedAtAction(nameof(GetById), new { id = profesion.Id }, profesion);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Profesion profesion)
        {
            if (id != profesion.Id) return BadRequest();
            _service.Update(profesion);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
