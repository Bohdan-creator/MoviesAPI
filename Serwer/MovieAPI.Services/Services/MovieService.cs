using AutoMapper;
using MovieAPI.DAL.Entities;
using MovieAPI.DAL.Interfaces;
using MovieAPI.Services.Interfaces;
using MovieAPI.Services.Models;
using MovieAPI.Services.Models.Movie;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Services.Services
{
    public class MovieService : IMoviesService
    {
        private readonly IMapper mapper;
        private readonly IMovieRepository movieRepository;

        public MovieService(IMapper mapper,IMovieRepository movieRepository)
        {
            this.mapper = mapper;
            this.movieRepository = movieRepository;
        }
        public async Task<bool> SaveMovie(MovieDto movieDto)
        {
            try
            {
                var movie = mapper.Map<Movies>(movieDto);
                movieRepository.Create(movie);
                await movieRepository.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
     
         public List<Movies> AllMovies()
         {
            var movies =  movieRepository.getAllMovies();
            if (movies == null)
            {
                return null;
            }
            return movies;
        }
    
    }
}
