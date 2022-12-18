using Application.Core;
using AutoMapper;
using FluentResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Interfaces;
using Reactivities.Contracts.Comments;
using Reactivities.Domain.Entities;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Comments.Commands
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, ServiceResponse<CommentDTO>>
    {
        private readonly ApplicationDbContext context;
        private readonly IUserAccessor userAccessor;
        private readonly IMapper mapper;

        public CreateCommentCommandHandler(ApplicationDbContext context, IUserAccessor userAccessor, IMapper mapper)
        {
            this.context = context;
            this.userAccessor = userAccessor;
            this.mapper = mapper;
        }

        async Task<ServiceResponse<CommentDTO>> IRequestHandler<CreateCommentCommand, ServiceResponse<CommentDTO>>.Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var user = await context.Users
                .Include(p => p.Photos)
                .FirstOrDefaultAsync(u => u.Email == userAccessor.GetUsername(), cancellationToken: cancellationToken);
            
            if (user == null) return null;

            var activity = await context.Activities.FindAsync(request.ActivityId);

            if (activity == null) return null;

            var comment = new Comment
            {
                Author = user,
                Activity = activity,
                Body = request.Body
            };

            var success = await context.SaveChangesAsync(cancellationToken) > 0;

            if (success) return ServiceResponse<CommentDTO>.Success(mapper.Map<CommentDTO>(comment));

            return ServiceResponse<CommentDTO>.Failure("Failed to add Comment");
        }
    }
}
