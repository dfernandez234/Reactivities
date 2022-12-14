using Application.Core;
using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Reactivities.Application.Activities.Commands.Cancel;
using Reactivities.Application.Activities.Commands.Create;
using Reactivities.Application.Activities.Commands.Delete;
using Reactivities.Application.Activities.Commands.Edit;
using Reactivities.Application.Activities.Queries.List;
using Reactivities.Application.Activities.Queries.SingleActivity;
using Reactivities.Application.Attendance.Commands;
using Reactivities.Application.Core;
using Reactivities.Contracts.Activities;
using Reactivities.Contracts.Authentication;

namespace Reactivities.API.Controllers
{
    [Route("activities/")]
    [ApiController]
    public class ActivitiesController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetActivityResponse>>>> GetActivities([FromQuery]PagingParams param)
        {
            var query = new ListQuery { Params = param };
            var authResult = await Mediator.Send(query);

            return HandlePagedResult(authResult);
        }

        [Authorize]
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<GetActivityResponse>>> GetSingleActivity(string Id)
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

        [Authorize(Policy = "IsActivityHost")]
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> EditActivity(string id, [FromBody]EditRequest request)
        {
            if(request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if(id.IsNullOrEmpty())
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

        [HttpPost]
        [Route("/attend/{id}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> Attend(string id)
        {
            var command = new UpdateAttendanceCommand(id);
            var authResult = await Mediator.Send(command);

            return HandleResult(authResult);
        }

        [Authorize(Policy = "IsActivityHost")]
        [HttpPatch]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> CancelActivity(string id)
        {
            var command = new CancelActivityCommand(id);
            var authResult = await Mediator.Send(command);

            return HandleResult(authResult);
        }
    }
}