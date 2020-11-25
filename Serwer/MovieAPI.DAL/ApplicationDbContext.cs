using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAPI.DAL
{
    using Microsoft.EntityFrameworkCore;
    using MovieAPI.DAL.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace TopTests.DAL
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Movies> Movies { get; set; }
            public DbSet<Comments> Comments { get; set; }
        }
    }

}
