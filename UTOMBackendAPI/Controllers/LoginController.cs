using Microsoft.AspNetCore.Mvc;
using UTOMBackendAPI.Model;

namespace UTOMBackendAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserSignIn userSignIn)
        {
            return Ok(new
            {
                Message = "Login successful",
                userInfo= userSignIn.UserName
            });
        }
    }
}
