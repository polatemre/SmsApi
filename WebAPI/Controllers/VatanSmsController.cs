using Business.Adapters.VatanSmsService;
using Business.Handlers.VatanSms.Queries;
using Entities.Dtos.VatanSms;
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
    public class VatanSmsController : BaseApiController
    {
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPost("SendSms1N")]
        public async Task<IActionResult> SendSms1N([FromBody] PostVatanSms1NQuery postVatanSms1NQuery)
        {
            var result = await Mediator.Send(postVatanSms1NQuery);

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
        public async Task<IActionResult> SendSmsNN([FromBody] PostVatanSmsNNQuery postVatanSmsNNQuery)
        {
            var result = await Mediator.Send(postVatanSmsNNQuery);

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
        public async Task<IActionResult> SmsTracking([FromBody] PostVatanSmsTakipQuery postVatanSmsTakipQuery)
        {
            var result = await Mediator.Send(postVatanSmsTakipQuery);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
