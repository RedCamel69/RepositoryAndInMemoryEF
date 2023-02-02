using RepositoryAndUnitOfWork.Models;

namespace RepositoryAndUnitOfWork.Services.BookService
{
    public interface IBookService
    {
        public List<Book> GetBooks();

        public List<Book> GetBooksByAuthor(int authorId);
    }
}
