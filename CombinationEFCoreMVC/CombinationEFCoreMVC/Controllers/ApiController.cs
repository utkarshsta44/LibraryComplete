using CombinationEFCoreMVC.Data;
using CombinationEFCoreMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CombinationEFCoreMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly LibraryDbContext _context;
        public ApiController(LibraryDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var books = _context.books.ToList();
            return books;
        }
    }
}
