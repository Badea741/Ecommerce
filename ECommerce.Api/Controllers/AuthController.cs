using AuthenticationServices.Authentication;
using AutoMapper;
using ECommerce.Shared.Dtos;
using ECommerce.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers;
[ApiController]
[Route("api/[controller]/[action]")]
[Authorize(AuthenticationSchemes = "Bearer")]
public class AuthenticationController : AuthController<ApplicationUser, ApplicationUserDto>
{
    public AuthenticationController(IAuthentication<ApplicationUser> auth, IMapper mapper, Serilog.ILogger logger) : base(auth, mapper, logger)
    {
    }
}