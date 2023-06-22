using System;
using CleanArchitecture.Application;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>() {
            new Movie(){Id = 1 , Name = "Name of Movie 1",Coast = 10},
            new Movie(){Id = 2 , Name = "Name of Movie 2",Coast = 20},
        };
        List<Movie> IMovieRepository.GetMovies()
        {
            return movies;
        }
    }
}

