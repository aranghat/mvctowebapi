using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibraryCore;
using RestSharp;

namespace MvcApplication.Controllers
{
    public class LoginController : Controller
    {
        RestClient client = new RestClient("http://localhost:54343/api");

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AuthRequest authRequest)
        {
            RestRequest request = new RestRequest("/login", Method.Post);
            request.AddJsonBody(authRequest);

            var jwtToken = await client.PostAsync<string>(request, CancellationToken.None);
            
            Response.Cookies.Append("Token",jwtToken);

            return View();
        }
    }
}