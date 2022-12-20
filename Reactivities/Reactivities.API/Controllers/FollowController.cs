using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Followings.Commands;
using Reactivities.Application.Followings.Queries;
using Reactivities.Contracts.Users;

namespace Reactivities.API.Controllers
{
    [ApiController]
    [Route("follow/")]
    public class FollowController : BaseApiController
    {
        [HttpPost]
        [Route("{username}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> Follow([FromRoute] string username)
        {
            return HandleResult(await Mediator.Send(new FollowToggle.Command { TargetUsername = username }));
        }

        [HttpGet]
        [Route("{username}")]
        public async Task<ActionResult<List<Profile>>> GetFollowings(string username, string predicate)
        {
            return HandleResult(await Mediator.Send(new FollowersList.Query { Username= username, Predicate = predicate }));
        }
    }
}
