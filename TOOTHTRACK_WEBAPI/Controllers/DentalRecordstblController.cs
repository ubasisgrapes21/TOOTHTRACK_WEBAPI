using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODELS.DTOs;
using MODELS;
using SERVICES;

namespace TOOTHTRACK_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DentalRecordstblController : ControllerBase
    {
        private readonly DentalRecordstblService _dentalrecordstblService = new DentalRecordstblService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll([FromQuery] DentalRecordsRequest parameter)
        {
            try
            {
                var data = await _dentalrecordstblService.GetAll(parameter);
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
                var data = await _dentalrecordstblService.GetById(id);
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
                var data = await _dentalrecordstblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] DentalRecordstbl dentalrecordstbl)
        {
            try
            {
                var data = await _dentalrecordstblService.Insert(dentalrecordstbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] DentalRecordstbl dentalrecordstbl)
        {
            try
            {
                var data = await _dentalrecordstblService.Update(dentalrecordstbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}