using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAPI.Services.Models.Comment
{
   public class AddCommentDto
    {
        public int MovieId { get; set; }
        public string Comment { get; set; }
    }
}
