using MediatR;
using Microsoft.AspNetCore.SignalR;
using Reactivities.Application.Comments.Commands;
using Reactivities.Application.Comments.Queries;

namespace Reactivities.API.SignalR
{
    public class ChatHub : Hub
    {
        private readonly IMediator mediator;

        public ChatHub(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task SendComment(CreateCommentCommand command)
        {
            var comment = await mediator.Send(command);
            await Clients.Group(command.ActivityId).SendAsync("ReceiveComment", comment.Data);
        }

        public override async Task OnConnectedAsync()
        {
            var httpContext = Context.GetHttpContext();
            var activityId = httpContext.Request.Query["activityId"];
            await Groups.AddToGroupAsync(Context.ConnectionId, activityId);
            var result = await mediator.Send(new ListComments.Query { ActivityId = activityId });
            await Clients.Caller.SendAsync("LoadComments", result.Data);
        }
    }
}
