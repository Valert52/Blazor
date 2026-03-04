using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abc.Data;

namespace Abc.Soft.Movies.Data
{
    public class AbcSoftMoviesContext : DbContext
    {
        public AbcSoftMoviesContext(DbContextOptions<AbcSoftMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}