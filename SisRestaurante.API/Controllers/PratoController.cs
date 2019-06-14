using Microsoft.AspNetCore.Mvc;
using SisRestaurante.Domain.Entities;
using SisRestaurante.Domain.Interfaces;
using System;

namespace SisRestaurante.API.Controllers
{
    [Route("api/prato")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        private IPratoService _service;
        public PratoController(IPratoService service)
        {
            _service = service;
        }

        // GET: api/prato/getall
        [HttpGet("getall")]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        // GET: api/prato/getone/id
        [HttpGet("getone/{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_service.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // POST: api/prato/create
        [HttpPost("create")]
        public IActionResult Post([FromBody] Prato prato)
        {
            try
            {
                if (prato == null)
                    return BadRequest("Objeto inválido");

                _service.Create(prato);

                return Created("getone", new { id = prato.Id });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // PUT: api/prato/update/5
        [HttpPut("update/{id}")]
        public IActionResult Put(int id, [FromBody] Prato prato)
        {
            try
            {
                if (prato == null)
                    return BadRequest("Objeto inválido");

                _service.Update(id, prato);

                return NoContent();

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE: api/prato/delete/id
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}