using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using weekendtask.Repository;
using weekendtask.Requests;

namespace weekendtask.Controllers
{
    [Route("api")]
    [ApiController]
    public class MoviesDbController : ControllerBase
    {
        private readonly IMovies repository;
        public MoviesDbController(IMovies repo)
        {
            this.repository = repo;
        }

        [HttpGet("languages")]
        public IActionResult languages()
        {
            return Ok(repository.AllLanguages());
        }


        [HttpGet("moviesbylanguage/{language}")]
        public IActionResult moviesbylanguage(string language)
        {
            return Ok(repository.AllMoviesByLanguage(language));
        }

        [HttpGet("moviereview/{movieName}")]
        public IActionResult moviereview(string movieName)
        {
            return Ok(repository.ReviewsByMovie(movieName));
        }


        [HttpPost("addreview")]

        public IActionResult addreview(AddReviews data)
        {
            return Ok(repository.AddReview(data));
        }
    }
}
