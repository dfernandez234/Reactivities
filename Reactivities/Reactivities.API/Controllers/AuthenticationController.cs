using Application.Core;
using AutoMapper;
using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Common.Interfaces.Authentication;
using Reactivities.Contracts.Authentication;
using Reactivities.Domain.Entities;
using System.Security.Claims;

namespace Reactivities.API.Controllers
{
    [AllowAnonymous]
    [Route("authentication/")]
    [ApiController]
    public class AuthenticationController : BaseApiController
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IMapper mapper;
        private readonly IJwtTokenGenerator tokenGenerator;

        public AuthenticationController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper, IJwtTokenGenerator tokenGenerator)
        {
            this.tokenGenerator = tokenGenerator;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<UserResponse>> Login([FromBody]LoginRequest loginRequest)
        {
            var user = await userManager.Users.Include(p => p.Photos)
                .FirstOrDefaultAsync(x => x.Email == loginRequest.Email);

            if (user == null)
            {
                return Unauthorized();
            }
            var isValidUser = await signInManager.CheckPasswordSignInAsync(user, loginRequest.Password, false);
            if (isValidUser.Succeeded) {
                return new UserResponse
                {
                    DisplayName = user.DisplayName,
                    Image = user?.Photos?.FirstOrDefault(x => x.IsMain)?.Url,
                    Token = tokenGenerator.GenerateToken(user),
                    Username = user.UserName
                };
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<UserResponse>> Register([FromBody]RegisterRequest registerRequest)
        {
            if(await userManager.Users.AnyAsync(x => x.Email == registerRequest.Email))
            {
                ModelState.AddModelError("email", $"Email {registerRequest.Email} is already registered");
                return ValidationProblem();
            }

            if (await userManager.Users.AnyAsync(x => x.UserName == registerRequest.Username))
            {
                ModelState.AddModelError("email", $"Username {registerRequest.Username} is already registered");
                return ValidationProblem();
            }

            var user = new AppUser
            {
                DisplayName = registerRequest.DisplayName,
                Email = registerRequest.Email,
                UserName = registerRequest.Username,
                NormalizedEmail = registerRequest.Email.ToUpper()
            };

            var result = await userManager.CreateAsync(user, registerRequest.Password);

            if (result.Succeeded)
            {
                return CreateUserObject(user);
            }

            return BadRequest("Something went wrong");
        }

        [HttpGet]
        public async Task<ActionResult<UserResponse>> GetCurrentUser()
        {
            var user = await userManager.Users.Include(p => p.Photos)
                .FirstOrDefaultAsync(x => x.Email == User.FindFirstValue(ClaimTypes.Email));
            return CreateUserObject(user);
        }

        private UserResponse CreateUserObject(AppUser user)
        {
            return new UserResponse
            {
                DisplayName = user.DisplayName,
                Image = user?.Photos?.FirstOrDefault(x => x.IsMain)?.Url,
                Username = user.UserName!,
                Token = tokenGenerator.GenerateToken(user),
            };
        }
    }
}
