using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAPI.DAL.Entities
{
    public class Movies
    {
        public Movies() { }
     
         public int Id { get; set; }
        public string Actors { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Awards { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string Language { get; set; }
        public string MetaScore { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Writer { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public Movies(int Id,string Actors,string Awards,string Type,string Rated,string Poster,string Runtime,string Director,string Genre,
            string Language,string Title,string Released, string Country,string Plot)
        {
            this.Id = Id;
            this.Actors = Actors;
            this.Awards = Awards;
            this.Type = Type;
            this.Rated = Rated;
            this.Poster = Poster;
            this.Runtime = Runtime;
            this.Director = Director;
            this.Genre = Genre;
            this.Language = Language;
            this.Title = Title;
            this.Released = Released;
            this.Country = Country;
            this.Plot = Plot;

        }
        public List<Comments> Comments { get; set; } = new List<Comments>();
    }
}
