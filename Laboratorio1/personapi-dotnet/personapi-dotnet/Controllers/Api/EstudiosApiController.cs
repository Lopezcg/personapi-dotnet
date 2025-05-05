using Microsoft.AspNetCore.Mvc;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Services.Interfaces;

namespace personapi_dotnet.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudiosApiController : ControllerBase
    {
        private readonly IEstudiosService _service;

        public EstudiosApiController(IEstudiosService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{cc_per}/{id_prof}")]
        public IActionResult GetById(int cc_per, int id_prof)
        {
            var estudio = _service.GetById(cc_per, id_prof);
            return estudio == null ? NotFound() : Ok(estudio);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Estudio estudio)
        {
            _service.Add(estudio);
            return CreatedAtAction(nameof(GetById), new { cc_per = estudio.CcPer, id_prof = estudio.IdProf }, estudio);
        }

        [HttpPut("{cc_per}/{id_prof}")]
        public IActionResult Update(int cc_per, int id_prof, [FromBody] Estudio estudio)
        {
            if (cc_per != estudio.CcPer || id_prof != estudio.IdProf)
                return BadRequest();

            _service.Update(estudio);
            return NoContent();
        }

        [HttpDelete("{cc_per}/{id_prof}")]
        public IActionResult Delete(int cc_per, int id_prof)
        {
            _service.Delete(cc_per, id_prof);
            return NoContent();
        }
    }
}
