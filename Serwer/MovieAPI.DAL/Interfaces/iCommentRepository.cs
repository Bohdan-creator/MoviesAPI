using MovieAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.DAL.Interfaces
{
    public interface iCommentRepository:IRepositoryBase<Comments>
    {
        Task<IEnumerable<Comments>> getAllComments(int id);
    }
}
