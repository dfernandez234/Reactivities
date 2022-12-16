using Application.Core;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Profiles.Queries;

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
    }
}
