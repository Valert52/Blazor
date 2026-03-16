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

        public DbSet<Movie> Movies { get; set; } = default!;
        public DbSet<Currency> Currency { get; set; } = default!;
        public DbSet<Country> Countries { get; set; } = default!;
    }
}