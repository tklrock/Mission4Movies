using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Movies.Models
{
    public class MovieContext: DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<MovieEntry> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Initial movie entires into the database
            mb.Entity<MovieEntry>().HasData(
                new MovieEntry
                {
                    movieId = 1,
                    category="Sci-Fi Thriller",
                    title="Interstellar",
                    year=2015,
                    director="Christpoher Nolan",
                    rating="PG-13",
                    edited=false,
                    lentTo="",
                    notes="Top 10"
                }
            );
            mb.Entity<MovieEntry>().HasData(
                new MovieEntry
                {
                    movieId = 2,
                    category = "French Musical Drama",
                    title = "Umbrellas of Cherbourg",
                    year = 1964,
                    director = "Jacques Demy",
                    rating = "PG",
                    edited = false,
                    lentTo = "Keanna",
                    notes = "Top 5"
                }
            );
            mb.Entity<MovieEntry>().HasData(
                new MovieEntry
                {
                    movieId = 3,
                    category = "Bibliographical Musical Drama",
                    title = "Tick, Tick... Boom!",
                    year = 2021,
                    director = "Lin-Manuel Miranda",
                    rating = "UR",
                    edited = false,
                    lentTo = "",
                    notes = "Top 20"
                }
            );
        }
    }
}
