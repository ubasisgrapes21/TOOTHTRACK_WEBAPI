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
    public class BillingtblController : ControllerBase
    {
        private readonly BillingtblService _billingtblService = new BillingtblService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll( [FromQuery] BillingRequest parameter)
        {
            try
            {
                var data = await _billingtblService.GetAll(parameter);
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
                var data = await _billingtblService.GetById(id);
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
                var data = await _billingtblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Billingtbl billingtbl)
        {
            try
            {
                var data = await _billingtblService.Insert(billingtbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Billingtbl billingtbl)
        {
            try
            {
                var data = await _billingtblService.Update(billingtbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}