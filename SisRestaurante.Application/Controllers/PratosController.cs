using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SisRestaurante.Domain.Interfaces;
using SisRestaurante.Service.Services;

namespace SisRestaurante.Application.Controllers
{
    [Route("api/[pratos]")]
    [ApiController]
    public class PratosController : ControllerBase
    {
        private IPratoService _service;
        public PratosController(IPratoService service)
        {
            _service = service;
        }
        // GET: api/Pratos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        // GET: api/Pratos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pratos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Pratos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
