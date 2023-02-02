using Microsoft.EntityFrameworkCore;
using RepositoryAndUnitOfWork.Models;

namespace RepositoryAndUnitOfWork.Data
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rating> Ratings{ get; set; }
    }
}
