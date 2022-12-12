using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Reactivities.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Infrastructure.Services
{
    internal class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public string? GetUsername()
        {
            var sum = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email);
            return sum!.Value;
        }
    }
}
