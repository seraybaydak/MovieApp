using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie>_movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie 
                {MovieId=1, 
                 Title = "film 1", 
                 Description = "açıklama 1", 
                 Director = "Yönetmen 1",
                 Players = new string[] { "oyuncu 1", "oyuncu 2" }, 
                 ImageUrl = "1.jpeg" ,
                GenreId = 1
                },
                 
                new Movie 
                {MovieId=2, 
                 Title = "film 2", 
                 Description = "açıklama 2", 
                 Director = "Yönetmen 2", 
                 Players = new string[] { "oyuncu 1", "oyuncu 2" }, 
                 ImageUrl = "1.jpeg" ,
                GenreId = 1
                },
                new Movie 
                {MovieId=3,
                 Title = "film 3", 
                 Description = "açıklama 3", 
                 Director = "Yönetmen 3",
                 Players = new string[] { "oyuncu 1", "oyuncu 2" }, 
                 ImageUrl = "1.jpeg" ,
                 GenreId = 3
                },
                new Movie
                {MovieId=1,
                 Title = "film 4",
                 Description = "açıklama 4",
                 Director = "Yönetmen 4",
                 Players = new string[] { "oyuncu 1", "oyuncu 2" },
                 ImageUrl = "1.jpeg",
                GenreId = 3
                },
                new Movie
                {MovieId=2,
                 Title = "film 5",
                 Description = "açıklama 5",
                 Director = "Yönetmen 5",
                 Players = new string[] { "oyuncu 1", "oyuncu 2" },
                 ImageUrl = "1.jpeg",
                GenreId = 3
                },
                new Movie
                {MovieId=3,
                 Title = "film 6",
                 Description = "açıklama 6",
                 Director = "Yönetmen 6",
                 Players = new string[] { "oyuncu 1", "oyuncu 2" },
                 ImageUrl = "1.jpeg",
                GenreId = 4
                }
            };
        }
            public static List<Movie> Movies
        { 
            get
            {
                return _movies;
            }
        }
        public static void Add(Movie movie)
        {
            movie.MovieId = _movies.Count() + 1;
            _movies.Add(movie);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.MovieId == id);
        }
        
    }
}
