using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPIBasicAuth.Entities;

namespace WebAPIBasicAuth.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var userList = new List<User>
            {
                new User{Id = 1, Username="admin", Password="123456"},
                new User{Id = 2, Username="user", Password="123456"}
            };
            return Ok(await Task.Run(()=>userList));
        }
    }
}
