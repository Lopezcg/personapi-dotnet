using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Services.Interfaces;

namespace personapi_dotnet.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaApiController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public PersonaApiController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_personaService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var persona = _personaService.GetById(id);
            if (persona == null)
                return NotFound();

            return Ok(persona);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Persona persona)
        {
            _personaService.Add(persona);
            return CreatedAtAction(nameof(GetById), new { id = persona.Cc }, persona);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Persona persona)
        {
            if (id != persona.Cc)
                return BadRequest();

            _personaService.Update(persona);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personaService.Delete(id);
            return NoContent();
        }
    }
}
