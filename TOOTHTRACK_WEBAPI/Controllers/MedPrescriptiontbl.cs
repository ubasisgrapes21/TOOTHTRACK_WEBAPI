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
    public class MedPrescriptiontblController : ControllerBase
    {
        private readonly MedPrescriptiontblService _medprescriptiontblService = new MedPrescriptiontblService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll([FromQuery]MedPrescriptionRequest parameter)
        {
            try
            {
                var data = await _medprescriptiontblService.GetAll(parameter);
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
                var data = await _medprescriptiontblService.GetById(id);
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
                var data = await _medprescriptiontblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] MedPrescriptiontbl medprescriptiontbl)
        {
            try
            {
                var data = await _medprescriptiontblService.Insert(medprescriptiontbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] MedPrescriptiontbl medprescriptiontbl)
        {
            try
            {
                var data = await _medprescriptiontblService.Update(medprescriptiontbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}