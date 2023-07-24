using CityInfo.Contexts;
using CityInfo.Entities;
using CityInfo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CityInfo.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class UserController : Controller
    {
        private readonly CityInfoContext _ctx;
        public UserController(CityInfoContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }
        [HttpPost]
        public IActionResult LoginAction([FromBody] UserDto userFromParams) {
            var users = _ctx.Users;
            User user=users.Where(x=>x.Username == userFromParams.Username&&x.Password==userFromParams.Password).FirstOrDefault();
            if(user == null)
            {
                return NotFound(false);
            }

            return Ok(true);
        
        }
    }
}
