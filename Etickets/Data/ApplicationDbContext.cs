﻿using Etickets.Models;
using Microsoft.EntityFrameworkCore;

namespace Etickets.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JUIUM6J\\SQLEXPRESS;Initial Catalog=Etickets;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuring the many-to-many relationship between Actor and Movie
            modelBuilder.Entity<ActorMovie>()
                .HasKey(am => new { am.ActorsId, am.MoviesId });
            modelBuilder.Entity<ActorMovie>()
                .HasOne(am => am.Actor)
                .WithMany(a => a.ActorMovies)
                .HasForeignKey(am => am.ActorsId);
            modelBuilder.Entity<ActorMovie>()
                .HasOne(am => am.Movie)
                .WithMany(m => m.ActorMovies)
                .HasForeignKey(am => am.MoviesId);

            

        }




    }
}
