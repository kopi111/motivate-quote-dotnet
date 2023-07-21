using Microsoft.AspNetCore.Mvc;

using MotivationAPI.Core.Interfaces.Services;

namespace MotivationAPI.Web.Controllers
{

    [ApiController]
    [Route("Motivation/")]
    public class MotivationQuotesAPIController : ControllerBase
    {
        private readonly IMotivationalQuotesService _service;

        public MotivationQuotesAPIController(IMotivationalQuotesService service)
        {
            _service = service;
        }

        

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public  async Task<IActionResult> MotivationQuote()
        {
            try
            {
                var result =  _service.GetMotivation();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


    }
}
