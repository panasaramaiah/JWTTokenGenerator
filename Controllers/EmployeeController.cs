using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokenGenerator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(new List<string>
            {
                "Ramaiah",
                "Kiran",
                "Ravi"
            });
        }
    }
}
