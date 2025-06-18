using Microsoft.EntityFrameworkCore;

namespace WEBAPI
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                               new Movie { Id = 1, Title = "Inception", Director = "Christopher Nolan", ReleaseDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Rating = 8.8m },
                               new Movie { Id = 2, Title = "The Godfather", Director = "Francis Ford Coppola", ReleaseDate = new DateTime(1972, 3, 24), Genre = "Crime", Rating = 9.2m }
                                                         );
        }
    }
}
