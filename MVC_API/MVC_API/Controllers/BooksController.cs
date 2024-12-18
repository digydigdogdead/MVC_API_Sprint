using Microsoft.AspNetCore.Mvc;

namespace MVC_API.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            Book? book = _bookService.GetBook(id);
            if (book != null) return Ok(book);
            else return BadRequest();
        }

        [HttpPost]
        public IActionResult PostBook(Book book)
        {
            _bookService.PostBook(book);
            return Created($"/books/{book.Id}", book);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            bool searchResult = _bookService.BookExists(id);
            if (!searchResult) return BadRequest();
            _bookService.DeleteBook(id);
            return NoContent();

        }
    }
}
