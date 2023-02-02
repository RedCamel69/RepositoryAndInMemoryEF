using RepositoryAndUnitOfWork.Models;

namespace RepositoryAndUnitOfWork.Services.AuthorService
{
    public interface IAuthorService
    {
        public List<Author> GetAuthors();
    }
}
