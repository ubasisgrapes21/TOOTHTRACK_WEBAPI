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
    public class TreatmentTypetblController : ControllerBase
    {
        private readonly TreatmentTypetblService _treatmenttypetblService = new TreatmentTypetblService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll([FromQuery]TreatmentTypetbl parameter)
        {
            try
            {
                var data = await _treatmenttypetblService.GetAll(parameter);
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
                var data = await _treatmenttypetblService.GetById(id);
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
                var data = await _treatmenttypetblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] TreatmentTypetbl treatmenttypetbl)
        {
            try
            {
                var data = await _treatmenttypetblService.Insert(treatmenttypetbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] TreatmentTypetbl treatmenttypetbl)
        {
            try
            {
                var data = await _treatmenttypetblService.Update(treatmenttypetbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}