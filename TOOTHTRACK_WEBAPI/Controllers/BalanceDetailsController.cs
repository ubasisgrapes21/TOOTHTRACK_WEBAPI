using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SERVICES;

namespace TOOTHTRACK_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BalanceDetailsController : ControllerBase
    {
        private readonly BalanceDetailsService _balancedetailsService = new BalanceDetailsService();

        [HttpGet("List")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _balancedetailsService.GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}