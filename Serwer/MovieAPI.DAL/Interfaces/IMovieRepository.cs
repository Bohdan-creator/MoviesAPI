using MovieAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.DAL.Interfaces
{
    public interface IMovieRepository:IRepositoryBase<Movies>
    {
        List<Movies> getAllMovies();
    }
}
