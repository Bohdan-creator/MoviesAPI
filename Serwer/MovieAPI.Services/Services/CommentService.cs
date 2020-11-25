using AutoMapper;
using MovieAPI.DAL.Entities;
using MovieAPI.DAL.Interfaces;
using MovieAPI.Services.Interfaces;
using MovieAPI.Services.Models.Comment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Services.Services
{
    public class CommentService : ICommentService
    {
        private readonly iCommentRepository commentRepository;
        private readonly IMapper mapper;
        public CommentService(iCommentRepository commentRepository,IMapper mapper)
        {
            this.commentRepository = commentRepository;
            this.mapper = mapper;
        }
        public async Task<bool> AddComment(AddCommentDto addComment)
        {
            if (addComment == null)
            {
                return false;
            }
            var comment = mapper.Map<Comments>(addComment);
            commentRepository.Create(comment);
            await commentRepository.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Comments>> getComments(int id)
        {
            var comments = await commentRepository.getAllComments(id);
            if (comments == null)
            {
                return null;
            }
            return comments;
        }
    }
}
