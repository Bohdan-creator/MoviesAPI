using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAPI.DAL.Entities
{
    public class Comments
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Comment { get; set; }
    }
}
