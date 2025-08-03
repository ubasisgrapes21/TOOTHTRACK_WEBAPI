using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODELS;
using MODELS.DTOs;
using SERVICES;

namespace TOOTHTRACK_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountService _accountService;
        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginPayLoad payLoad)
        {
            try
            {
                var data = await _accountService.Login(payLoad);
                return Ok(
                    new
                    {   
                        Token = data.Item1,
                        User = data.Item2 
                    }
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
