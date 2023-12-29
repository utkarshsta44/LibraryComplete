using CombinationEFCoreMVC.Data;
using CombinationEFCoreMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CombinationEFCoreMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryDbContext _context;
        public BookController(LibraryDbContext context)
        {
            _context = context;
        }


        public IActionResult ShowResult()
        {
            var books = _context.books.ToList();

            return View(books);
        }

       

        [HttpPost]
        public IActionResult Create(Book book)
        {
            return View("ShowResult", book);
        }

        
    }
}
