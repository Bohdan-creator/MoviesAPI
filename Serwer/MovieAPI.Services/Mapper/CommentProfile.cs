using AutoMapper;
using MovieAPI.DAL.Entities;
using MovieAPI.Services.Models.Comment;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAPI.Services.Mapper
{
   public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            CreateMap<AddCommentDto, Comments>();
        }
    }
}
