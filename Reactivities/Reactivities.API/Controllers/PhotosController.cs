using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Photos.Commands.Add;
using Reactivities.Application.Photos.Commands.Delete;
using Reactivities.Application.Photos.Commands.SetMain;
using Reactivities.Domain.Entities;

namespace Reactivities.API.Controllers
{
    [Route("photos/")]
    [ApiController]
    public class PhotosController : BaseApiController
    {
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<ServiceResponse<Photo>>> AddPhoto([FromForm] AddPhoto.Command command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [HttpPost]
        [Route("delete/{id}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> DeletePhoto(string Id)
        {
            return HandleResult(await Mediator.Send(new DeletePhoto.Command { Id = Id }));
        }

        [HttpPost]
        [Route("setMain/{id}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> SetMainPhoto(string Id)
        {
            return HandleResult(await Mediator.Send(new SetMainPhoto.Command { Id = Id }));
        }
    }
}
