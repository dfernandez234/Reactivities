using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Profiles.Command;
using Reactivities.Application.Profiles.Queries;
using Reactivities.Contracts.Users;

namespace Reactivities.API.Controllers
{
    [Route("profiles/")]
    [ApiController]
    public class ProfileController : BaseApiController
    {
        [HttpGet]
        [Route("{username}")]

        public async Task<ActionResult<ServiceResponse<Reactivities.Contracts.Users.Profile>>> GetProfile([FromRoute] string username)
        {
            return HandleResult(await Mediator.Send(new ProfileDetails.Query { Username = username }));
        }


        [HttpPut]
        [Route("{username}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> UpdateProfile([FromBody] UpdateProfile updates)
        {
            var command = new UpdateProfileCommand(updates);
            var result = await Mediator.Send(command);

            return HandleResult(result);
        }
    }
}
