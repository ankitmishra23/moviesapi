using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace weekendtask.Models
{
    public class MoviesDbContext:DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options):base(options)
        {

        }

        public DbSet<Languages> Languages { get; set; }

        public DbSet<Movies> MyMovies { get; set; }

        public DbSet<Reviews> MyReviews { get; set; }
    }
}
