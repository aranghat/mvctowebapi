using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibraryCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private List<Book> books = new List<Book>();

        public BooksController()
        {
            books.Add(new Book{ Author = "Author 1"
                                , Category = BookCategory.Comics
                                , Title = "Book 1"
            });

            books.Add(new Book
            {
                Author = "Author 2"
                ,
                Category = BookCategory.Comics
                ,
                Title = "Book 2"
            });

            books.Add(new Book
            {
                Author = "Author 3"
                ,
                Category = BookCategory.Comics
                ,
                Title = "Book 3"
            });
        }


        // GET api/values 
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(books);
        }

        
    }
}
