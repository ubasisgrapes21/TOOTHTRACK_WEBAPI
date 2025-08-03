using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODELS;
using SERVICES;

namespace TOOTHTRACK_WEBAPI.Controllers
{
    [Route("api/dentisttbl")]
    [ApiController]
    [Authorize]

    public class DentisttblController : ControllerBase
    {
        private readonly DentisttblService _dentisttblService = new DentisttblService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll([FromQuery]Dentisttbl parameter)
        {
            try
            {
                var data = await _dentisttblService.GetAll(parameter);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var data = await _dentisttblService.GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            try
            {
                var data = await _dentisttblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Dentisttbl dentisttbl)
        {
            try
            {
                var data = await _dentisttblService.Insert(dentisttbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Dentisttbl dentisttbl)
        {
            try
            {
                var data = await _dentisttblService.Update(dentisttbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}