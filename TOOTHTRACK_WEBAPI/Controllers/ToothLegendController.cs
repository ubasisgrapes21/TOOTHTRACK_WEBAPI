using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODELS;
using SERVICES;

namespace TOOTHTRACK_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToothLegendtblController : ControllerBase
    {
        private readonly ToothLegendtblService _toothlegendtblService = new ToothLegendtblService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll([FromQuery] ToothLegendtbl parameter)
        {
            try
            {
                var data = await _toothlegendtblService.GetAll(parameter);
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
                var data = await _toothlegendtblService.GetById(id);
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
                var data = await _toothlegendtblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] ToothLegendtbl toothlegendtbl)
        {
            try
            {
                var data = await _toothlegendtblService.Insert(toothlegendtbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ToothLegendtbl toothlegendtbl)
        {
            try
            {
                var data = await _toothlegendtblService.Update(toothlegendtbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}