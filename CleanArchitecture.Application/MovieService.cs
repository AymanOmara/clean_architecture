using System;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository repository) {
            _movieRepository = repository;
        }

        List<Movie> IMovieService.GetMovies()
        {
            return _movieRepository.GetMovies();
        }
    }
}

