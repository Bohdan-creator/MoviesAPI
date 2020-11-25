using MovieAPI.DAL.Entities;
using MovieAPI.Services.Models.Comment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Services.Interfaces
{
    public interface ICommentService
    {
        Task<bool> AddComment(AddCommentDto addComment);
        Task<IEnumerable<Comments>> getComments(int id);
    }
}
