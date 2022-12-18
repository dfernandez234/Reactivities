using Application.Core;
using MediatR;
using Reactivities.Contracts.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Comments.Commands
{
    public record CreateCommentCommand(
        string Body,
        string ActivityId):IRequest<ServiceResponse<CommentDTO>>;
}
