using JWTTokenGenerator.Models;
using JWTTokenGenerator.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokenGenerator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public AuthController(
            ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login(
            LoginRequest request)
        {
            if (request.UserName == "admin"
                && request.Password == "123")
            {
                var token =
                    _tokenService.GenerateToken(
                        request.UserName);

                return Ok(new
                {
                    Token = token
                });
            }

            return Unauthorized();
        }
    }
}
