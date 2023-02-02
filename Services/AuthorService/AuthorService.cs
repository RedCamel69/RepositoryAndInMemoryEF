using Microsoft.EntityFrameworkCore;
using RepositoryAndUnitOfWork.Data;
using RepositoryAndUnitOfWork.Models;

namespace RepositoryAndUnitOfWork.Services.AuthorService
{
    public class AuthorService : IAuthorService
    {
        private readonly ApiContext _context;
        public AuthorService(ApiContext context)
        {
            _context = context;
        }

        public List<Author> GetAuthors()
        {
            var list = _context.Authors
                .Include(a => a.Books)
                .ThenInclude(b=>b.StarRating)
                .ToList();
         
            return list;            
        }
    }
}
