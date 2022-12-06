using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Reactivities.API.Controllers
{
    [ApiController]
    [Route("api/")]
    public class BaseApiController : ControllerBase
    {
        private IMediator? _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        protected ActionResult HandleResult<T>(ServiceResponse<T> result)
        {
            if(result.Successful && result.Data != null)
            {
                return Ok(result);
            }
            if(result.Successful && result.Data == null)
            {
                return NotFound();
            }
            return BadRequest(result);
        }
    }
}
