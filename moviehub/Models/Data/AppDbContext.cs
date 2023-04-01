
using Microsoft.EntityFrameworkCore;

namespace moviehub.Models.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovieModel>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<ActorMovieModel>().HasOne(m => m.Movie).WithMany(am => 
            am.ActorMovies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<ActorMovieModel>().HasOne(m => m.Actor).WithMany(am =>
            am.ActorMovies).HasForeignKey(m => m.ActorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<ActorMovieModel> actorMovies { get; set; }
        public DbSet<CinemaModel> Cinema { get; set; }
        public DbSet<DirectorModel> Directors { get; set; }

    }
}
