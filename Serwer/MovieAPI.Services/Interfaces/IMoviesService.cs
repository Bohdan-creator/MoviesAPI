using MovieAPI.DAL.Entities;
using MovieAPI.Services.Models;
using MovieAPI.Services.Models.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Services.Interfaces
{
   public interface IMoviesService
    {
        Task<bool> SaveMovie(MovieDto movieDto);
        List<Movies> AllMovies();

    }
}
