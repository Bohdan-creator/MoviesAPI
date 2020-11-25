using Microsoft.EntityFrameworkCore;
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
    public class CommentRepository : RepositoryBase<Comments>, iCommentRepository
    {
        public CommentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<Comments>> getAllComments(int id)
        {
            return await context.Set<Comments>()
                 .Where(e => e.MovieId == id)
                 .ToListAsync();
        }
    }
}
