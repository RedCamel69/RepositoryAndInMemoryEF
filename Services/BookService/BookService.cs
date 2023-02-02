using Microsoft.EntityFrameworkCore;
using RepositoryAndUnitOfWork.Data;
using RepositoryAndUnitOfWork.Models;

namespace RepositoryAndUnitOfWork.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly ApiContext _context;
        public BookService(ApiContext context)
        {
            _context = context;
        }
        public List<Book> GetBooks()
        {
          var list = _context.Books
            .ToList();
            return list;            
        }

        public List<Book> GetBooksByAuthor(int authorId)
        {
            var list = _context.Books
                //query shadow property
                //https://learn.microsoft.com/en-us/ef/core/modeling/shadow-properties
                .Where(child => EF.Property<int?>(child, "AuthorId") == authorId) 
                .Include(x=>x.StarRating)
                .ToList();
            return list;
        }
    }
}
