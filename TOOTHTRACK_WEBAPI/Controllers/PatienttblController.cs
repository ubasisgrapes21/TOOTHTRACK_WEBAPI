using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODELS;
using SERVICES;

namespace TOOTHTRACK_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PatienttblController : ControllerBase
    {
        private readonly PatienttblService _patienttblService = new PatienttblService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll([FromQuery]Patienttbl parameter)
        {
            try
            {
                var data = await _patienttblService.GetAll(parameter);
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
                var data = await _patienttblService.GetById(id);
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
                var data = await _patienttblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Patienttbl patienttbl)
        {
            try
            {
                var data = await _patienttblService.Insert(patienttbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Patienttbl patienttbl)
        {
            try
            {
                var data = await _patienttblService.Update(patienttbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}