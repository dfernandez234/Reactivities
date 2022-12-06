using Application.Core;
using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Activities.Commands.Create;
using Reactivities.Application.Activities.Commands.Delete;
using Reactivities.Application.Activities.Commands.Edit;
using Reactivities.Application.Activities.Queries.List;
using Reactivities.Application.Activities.Queries.SingleActivity;
using Reactivities.Contracts.Activities;

namespace Reactivities.API.Controllers
{
    [Route("activities/")]
    [ApiController]
    public class ActivitiesController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetActivityResponse>>>> GetActivities()
        {
            var query = new ListQuery();
            var authResult = await Mediator.Send(query);

            return HandleResult(authResult);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<GetActivityResponse>>> GetSingleActivity(Guid Id)
        {
            if (Id.Equals(null))
            {
                throw new ArgumentNullException(nameof(Id));
            }

            var query = new SingleActivityQuery(Id);
            var authResult = await Mediator.Send(query);

            return HandleResult(authResult);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Unit>>> CreateActivity([FromBody] CreateRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var command = new ActivityCreateCommand(request);
            var authResult = await Mediator.Send(command);

            return HandleResult(authResult);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> EditActivity(Guid id, [FromBody]EditRequest request)
        {
            if(request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if(id.Equals(Guid.Empty))
            {
                throw new ArgumentException("ID cannot be null");
            }

            var command = new ActivityEditCommand(id, request);
            var authResult = await Mediator.Send(command);

            return HandleResult(authResult);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> DeleteActivity(Guid Id)
        {
            if (Id.Equals(null))
            {
                throw new ArgumentNullException(nameof(Id));
            }

            var command = new ActivityDeleteCommand(Id);
            var authResult = await Mediator.Send(command);

            return HandleResult(authResult);
        }
    }
}