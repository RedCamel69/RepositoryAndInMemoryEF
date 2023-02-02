using RepositoryAndUnitOfWork.Data;
using RepositoryAndUnitOfWork.Models;
using System;

namespace RepositoryAndUnitOfWork.Helper
{
    public static class DataPump{
    public static void AddData(WebApplication app)
    {
        var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetService<ApiContext>();

            using (var context = new ApiContext())
            {
                var ratings = new List<Rating>
                {
                    new Rating()
                    {
                                  Id=1,
                                  Name = "Five Star",
                                  Description = "Outstanding"
                    },
                    new Rating()
                    {
                                  Id=2,
                                  Name = "Four Star",
                                  Description = "Very Good"
                    },
                    new Rating()
                    {
                                  Id=3,
                                  Name = "Three Star",
                                  Description = "Average"
                    },
                    new Rating()
                    {
                                  Id=4,
                                  Name = "Two Star",
                                  Description = "Below Average"
                    },
                    new Rating()
                    {
                                  Id=5,
                                  Name = "One Star",
                                  Description = "Poor"
                    }
                };

                var fiveStarRating = ratings.FirstOrDefault(x => x.Id == 1);
                var fourStarRating = ratings.FirstOrDefault(x => x.Id == 2);
                var threeStarRating = ratings.FirstOrDefault(x => x.Id == 3);
                var twoStarRating = ratings.FirstOrDefault(x => x.Id == 4);
                var oneStarRating = ratings.FirstOrDefault(x => x.Id == 5);

                var authors = new List<Author>
                {
                new Author
                {
                    FirstName ="Stephen",
                    LastName ="King",
                     Books = new List<Book>()
                    {
                        new Book 
                        {
                            Title = "The Stand",
                            StarRating = fiveStarRating                          
                        },
                        new Book 
                        { 
                            Title = "The Shining",
                            StarRating = fiveStarRating
                        },
                        new Book 
                        { 
                            Title = "Cujo",
                            StarRating = oneStarRating
                        }
                    }
                }
                ,
                new Author
                {
                    FirstName ="William",
                    LastName ="Shakespear",
                    Books = new List<Book>()
                    {
                        new Book { Title = "KIng Lear", StarRating =fiveStarRating},
                        new Book { Title = "Twelfth Night", StarRating = fourStarRating},
                        new Book { Title = "The Merchant Of Venice", StarRating = fiveStarRating}
                    }
                }
                };
                context.Authors.AddRange(authors);
                context.SaveChanges();
            }
        }

    }
}
