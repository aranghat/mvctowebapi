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
    public class HomeController : Controller
    {
        RestClient client = new RestClient("http://localhost:54343/api");

        public async Task<IActionResult> Index()
        {

            RestRequest request = new RestRequest("/books", Method.Get);
            request.AddHeader("Authentication", "Bearer ABCD123456");

            List<Book> books = await client.GetAsync<List<Book>>(request,CancellationToken.None);

            return View(books);
        }
    }
}