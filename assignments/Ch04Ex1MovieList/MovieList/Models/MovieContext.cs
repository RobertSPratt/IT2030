using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "R", Name = "RomCom" },
                new Genre { GenreId = "S", Name = "SciFi" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Casablanca",
                    Year = 1942,
                    GenreId = "D",
                    Rating = 5
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Wonder Woman",
                    Year = 2017,
                    GenreId = "A",
                    Rating = 3
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Moonstruck",
                    Year = 1988,
                    GenreId = "R",
                    Rating = 4
                }
            );
        }
    }
}