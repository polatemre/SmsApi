using Business.Handlers.IletiMerkeziSms.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class IletiMerkeziSmsController : BaseApiController
    {
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPost("SendSms")]
        public async Task<IActionResult> SendSms([FromBody] PostIletiMerkeziSmsQuery postIletiMerkeziSmsQuery)
        {
            var result = await Mediator.Send(postIletiMerkeziSmsQuery);

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
        [HttpPost("CancelOrder")]
        public async Task<IActionResult> CancelOrder([FromBody] PostIletiMerkeziCancelOrderQuery postIletiMerkeziCancelOrderQuery)
        {
            var result = await Mediator.Send(postIletiMerkeziCancelOrderQuery);

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
        [HttpPost("GetBalance")]
        public async Task<IActionResult> GetBalance([FromBody] PostIletiMerkeziGetBalanceQuery postIletiMerkeziGetBalanceQuery)
        {
            var result = await Mediator.Send(postIletiMerkeziGetBalanceQuery);

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
        [HttpPost("GetReport")]
        public async Task<IActionResult> GetReport([FromBody] PostIletiMerkeziGetReportQuery postIletiMerkeziGetReportQuery)
        {
            var result = await Mediator.Send(postIletiMerkeziGetReportQuery);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
