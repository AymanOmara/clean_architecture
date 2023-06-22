using System;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application
{
	public interface IMovieService
	{
		List<Movie> GetMovies();
	}
}

