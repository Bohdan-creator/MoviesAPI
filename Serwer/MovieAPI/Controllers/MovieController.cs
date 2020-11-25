using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.DAL.Entities;
using MovieAPI.Services.Interfaces;
using MovieAPI.Services.Models;
using MovieAPI.Services.Models.Movie;

namespace MovieAPI.Controllers
{
    [Route("api/getSaveMovie")]
    [ApiController]

    public class MovieController : Controller
    {
        private readonly IMoviesService moviesService;

        public MovieController(IMoviesService moviesService)
        {
           this.moviesService = moviesService;
        }
        [HttpPost]
        public async Task<IActionResult> SaveFilm(MovieDto movies)
        {
            if (!await moviesService.SaveMovie(movies))
            {
                return BadRequest("Film don't save");
            }

            return Ok();

        }
        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var movies =  moviesService.AllMovies();
            if (movies == null)
            {
                return NotFound();
            }
            return Ok(movies);
        }
    }
}