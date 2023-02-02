using Microsoft.AspNetCore.Mvc;
using RepositoryAndUnitOfWork.Models;
using RepositoryAndUnitOfWork.Services.AuthorService;

namespace RepositoryAndUnitOfWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService  = authorService;
        }
        [HttpGet]
        public ActionResult<List<Author>> Get()
        {
            return Ok(_authorService.GetAuthors());
        }
    }
}
