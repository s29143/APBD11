using APBD11.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD11.Context;

public class MvcMovieContext : DbContext
{
    public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; }
}