﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4Movies.Models;

namespace Mission4Movies.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4Movies.Models.MovieEntry", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("movieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            category = "Sci-Fi Thriller",
                            director = "Christpoher Nolan",
                            edited = false,
                            lentTo = "",
                            notes = "Top 10",
                            rating = "PG-13",
                            title = "Interstellar",
                            year = 2015
                        },
                        new
                        {
                            movieId = 2,
                            category = "French Musical Drama",
                            director = "Jacques Demy",
                            edited = false,
                            lentTo = "Keanna",
                            notes = "Top 5",
                            rating = "PG",
                            title = "Umbrellas of Cherbourg",
                            year = 1964
                        },
                        new
                        {
                            movieId = 3,
                            category = "Bibliographical Musical Drama",
                            director = "Lin-Manuel Miranda",
                            edited = false,
                            lentTo = "",
                            notes = "Top 20",
                            rating = "UR",
                            title = "Tick, Tick... Boom!",
                            year = 2021
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
