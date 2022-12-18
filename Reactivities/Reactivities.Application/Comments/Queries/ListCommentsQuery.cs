using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Contracts.Comments;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Comments.Queries
{
    public class ListComments
    {
        public class Query : IRequest<ServiceResponse<List<CommentDTO>>>
        {
            public string ActivityId { get; set; }
        }

        public class ListCommentsQueryHandler : IRequestHandler<Query, ServiceResponse<List<CommentDTO>>>
        {
            private readonly ApplicationDbContext context;
            private readonly IMapper mapper;

            public ListCommentsQueryHandler(ApplicationDbContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<List<CommentDTO>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var comments = await context.Comments
                    .Where(x => x.Activity.ActivityId== request.ActivityId)
                    .OrderBy(x => x.CreatedAt)
                    .ProjectTo<CommentDTO>(mapper.ConfigurationProvider)
                    .ToListAsync();

                return ServiceResponse<List<CommentDTO>>.Success(comments);
            }
        }
    }
}
