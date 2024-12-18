using Microsoft.AspNetCore.Mvc;

namespace MVC_API.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly AuthorService _authorService;
        public AuthorsController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _authorService.GetAllAuthors();
            return Ok(authors);
        }

    }
}
