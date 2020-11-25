using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Services.Interfaces;
using MovieAPI.Services.Models.Comment;

namespace MovieAPI.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;
        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        [HttpPost]
        public async Task<IActionResult> AddCommment(AddCommentDto addCommentDto) 
        {
             if(!await commentService.AddComment(addCommentDto))
            {
                return BadRequest("Comment not added");
            }
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComments(string id)
        {
            var comments = await commentService.getComments(Int32.Parse(id));
            if(comments==null)
            {
                return BadRequest("You don't have comments");
            }
            return Ok(comments);
        }
    }
}