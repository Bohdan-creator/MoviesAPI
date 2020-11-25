using AutoMapper;
using MovieAPI.DAL.Entities;
using MovieAPI.Services.Models;
using MovieAPI.Services.Models.Movie;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAPI.Services.Mapper
{
    public class MoviesProfile:Profile
    {
        public MoviesProfile()
        {
            CreateMap<MovieDto, Movies>();
        }
    }
}
