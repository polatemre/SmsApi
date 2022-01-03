using Business.Adapters.OztekSmsService;
using Business.Handlers.OztekSms.Queries;
using Entities.Dtos.OztekSms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class OztekSmsController : BaseApiController
    {
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPost("SendSms1N")]
        public async Task<IActionResult> SendSms1N([FromBody] PostOztekSms1NQuery postOztekSms1NQuery)
        {
            var result = await Mediator.Send(postOztekSms1NQuery);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPost("SendSmsNN")]
        public async Task<IActionResult> SendSmsNN([FromBody] PostOztekSmsNNQuery postOztekSmsNNQuery)
        {
            var result = await Mediator.Send(postOztekSmsNNQuery);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPost("SmsTracking")]
        public async Task<IActionResult> SmsTracking([FromBody] PostOztekSmsTakipQuery postOztekSmsTakipQuery)
        {
            var result = await Mediator.Send(postOztekSmsTakipQuery);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
