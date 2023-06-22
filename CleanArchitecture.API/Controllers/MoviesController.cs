using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application;
using CleanArchitecture.Domain;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _service;
        public MoviesController(IMovieService service)
        {
            _service = service;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return Ok( _service.GetMovies());
        }

    }
}

