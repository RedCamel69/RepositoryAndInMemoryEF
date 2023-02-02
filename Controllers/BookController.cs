using Microsoft.AspNetCore.Mvc;
using RepositoryAndUnitOfWork.Models;
using RepositoryAndUnitOfWork.Services.AuthorService;
using RepositoryAndUnitOfWork.Services.BookService;

namespace RepositoryAndUnitOfWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            return Ok(_bookService.GetBooks());
        }

        [Route("/{authorId}")]
        [HttpGet]
        public ActionResult<List<Book>> GetBooksForAuthor(int authorId)
        {
            return Ok(_bookService.GetBooksByAuthor(authorId));
        }
    }
}
