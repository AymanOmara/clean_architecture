using System;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application
{
	public interface IMovieRepository
	{
		List<Movie> GetMovies();
	}
}

