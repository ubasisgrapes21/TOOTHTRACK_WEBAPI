using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODELS;
using MODELS.DTOs;
using SERVICES;

namespace TOOTHTRACK_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TreatmenttblController : ControllerBase
    {
        private readonly TreatmenttblService _treatmenttblService = new TreatmenttblService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll([FromQuery]TreatmentRequest parameter)
        {
            try
            {
                var data = await _treatmenttblService.GetAll(parameter);
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
                var data = await _treatmenttblService.GetById(id);
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
                var data = await _treatmenttblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Treatmenttbl treatmenttbl)
        {
            try
            {
                var data = await _treatmenttblService.Insert(treatmenttbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Treatmenttbl treatmenttbl)
        {
            try
            {
                var data = await _treatmenttblService.Update(treatmenttbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}