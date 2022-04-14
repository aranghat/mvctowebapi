using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLibraryCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private List<User> users = new List<User>();

        public LoginController()
        {
            users.Add(new User { Email = "sreehariis@gmail.com",Name="Sreehari Aranghat",Password = "12345"});
        }

        [HttpPost]
        public IActionResult Post(AuthRequest request)
        {
            string jwtToken = "";

            if (users.Any(d => d.Email == request.Email && d.Password == request.Password))
            {
                jwtToken = "ABCD1234567";
            }

            return Ok(jwtToken);
        }
    }

   
}