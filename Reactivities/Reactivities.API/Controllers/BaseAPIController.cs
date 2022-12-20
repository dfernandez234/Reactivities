using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reactivities.API.Extensions;
using Reactivities.Application.Core;

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

        protected ActionResult HandlePagedResult<T>(ServiceResponse<PagedList<T>> result)
        {
            if(result == null) return NotFound();
            if(result.Successful && result.Data != null)
            {
                Response.AddPaginationHeader(result.Data.CurrentPage, result.Data.PageSize,
                    result.Data.TotalCount, result.Data.TotalPages);
                return Ok(result.Data);
            }

            if(result.Successful && result.Data == null)
                return NotFound();

            return BadRequest(result.Error);
        }
    }
}
