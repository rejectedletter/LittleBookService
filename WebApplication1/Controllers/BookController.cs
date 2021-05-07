using Aplicacion;
using Dominio.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private static readonly BookService bookService = new BookService();
        

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
            
        }
        
        [HttpGet]
        public List<Book> Get()
        {
           return bookService.GetAll();
        }

       
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Book> CreateAsync([FromBody]JsonElement body)
        {
            string json = JsonSerializer.Serialize(body);
            var newBook = JsonSerializer.Deserialize<Book>(json);

            return CreatedAtAction(string.Empty , null);
        }
    }
}
