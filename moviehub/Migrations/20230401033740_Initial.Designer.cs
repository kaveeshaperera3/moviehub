﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using moviehub.Models.Data;

#nullable disable

namespace moviehub.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230401033740_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("moviehub.Models.ActorModel", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorId"));

                    b.Property<string>("ActorDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActorProfilePicURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("moviehub.Models.ActorMovieModel", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("actorMovies");
                });

            modelBuilder.Entity("moviehub.Models.CinemaModel", b =>
                {
                    b.Property<int>("CinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CinemaId"));

                    b.Property<string>("CinemaDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CinemaImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CinemaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CinemaId");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("moviehub.Models.DirectorModel", b =>
                {
                    b.Property<int>("DirectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DirectoId"));

                    b.Property<string>("DirectorDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirectoId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("moviehub.Models.MovieModel", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<string>("MoiveDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoiveEndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoiveMovieURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoiveName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoiveStartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("CinemaId");

                    b.HasIndex("DirectorId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("moviehub.Models.ActorMovieModel", b =>
                {
                    b.HasOne("moviehub.Models.ActorModel", "Actor")
                        .WithMany("ActorMovies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("moviehub.Models.MovieModel", "Movie")
                        .WithMany("ActorMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("moviehub.Models.MovieModel", b =>
                {
                    b.HasOne("moviehub.Models.CinemaModel", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("moviehub.Models.DirectorModel", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("moviehub.Models.ActorModel", b =>
                {
                    b.Navigation("ActorMovies");
                });

            modelBuilder.Entity("moviehub.Models.CinemaModel", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("moviehub.Models.DirectorModel", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("moviehub.Models.MovieModel", b =>
                {
                    b.Navigation("ActorMovies");
                });
#pragma warning restore 612, 618
        }
    }
}
