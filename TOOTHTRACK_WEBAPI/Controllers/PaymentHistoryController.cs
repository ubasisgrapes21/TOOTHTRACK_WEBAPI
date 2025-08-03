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
    public class PaymentHistorytblController : ControllerBase
    {
        private readonly PaymentHistorytblService _paymenthistorytblService = new PaymentHistorytblService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll([FromQuery]PaymentHistoryRequest parameter)
        {
            try
            {
                var data = await _paymenthistorytblService.GetAll(parameter);
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
                var data = await _paymenthistorytblService.GetById(id);
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
                var data = await _paymenthistorytblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] PaymentHistorytbl paymenthistorytbl)
        {
            try
            {
                var data = await _paymenthistorytblService.Insert(paymenthistorytbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PaymentHistorytbl paymenthistorytbl)
        {
            try
            {
                var data = await _paymenthistorytblService.Update(paymenthistorytbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}