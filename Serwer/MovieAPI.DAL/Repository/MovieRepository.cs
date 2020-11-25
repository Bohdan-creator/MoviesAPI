using MovieAPI.DAL.Entities;
using MovieAPI.DAL.Interfaces;
using MovieAPI.DAL.TopTests.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.DAL.Repository
{
    public class MovieRepository:RepositoryBase<Movies>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Movies> getAllMovies()
        {
            List <Movies> movies = new List<Movies>();
            IEnumerable<Movies> mov;

            var d =  from a in context.Movies
                   join b in context.Comments on a.Id equals b.MovieId
                     into cj from c in cj.DefaultIfEmpty()
                     select new { prop1=a,prop2 = c};
           
            foreach(var i in d)
            {
                Movies movie = new Movies(i.prop1.Id, i.prop1.Actors, i.prop1.Awards,
                    i.prop1.Type, i.prop1.Rated, i.prop1.Poster, i.prop1.Runtime,
                    i.prop1.Director, i.prop1.Genre, i.prop1.Language, i.prop1.Title,
                    i.prop1.Released, i.prop1.Country, i.prop1.Plot);
                foreach(var j in d)
                {
                    if (i.prop1.Id == j.prop1.Id)
                    {

                        movie.Comments.Add(j.prop2);
                    }
                }
                movies.Add(movie);
            }
            var list_movies = movies.GroupBy(x => x.Id)
                                  .Select(g => g.First())
                                  .ToList();
            return list_movies;
        }
    }
}
