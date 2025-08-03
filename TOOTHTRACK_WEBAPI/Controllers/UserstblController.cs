using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODELS;
using MODELS.DTOs;
using SERVICES;

namespace TOOTHTRACK_WEBAPI.Controllers
{
    [Route("api/userstbl")]
    [ApiController]
    [Authorize]
    public class UserstblController : ControllerBase
    {
        private readonly UserstblService _userstblService = new UserstblService();

        [HttpGet("list")]
        public async Task<IActionResult> GetAll([FromQuery]UsersRequest parameter)
        {
            try
            {
                var data = await _userstblService.GetAll(parameter);
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
                var data = await _userstblService.GetById(id);
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
                var data = await _userstblService.DeleteById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Userstbl userstbl)
        {
            try
            {
                var data = await _userstblService.Insert(userstbl);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Userstbl userstbl)
        {
            try
            {
                var data = await _userstblService.Update(userstbl);
                return Ok(data);
            } 
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
