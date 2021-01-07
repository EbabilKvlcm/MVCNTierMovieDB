using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext : DbContext
    {
        //Furkan Koçhan buradan itabaren devam edicek..

        public MyContext() : base("eboConnetion")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArtistMap());
            modelBuilder.Configurations.Add(new DirectorMap());
            modelBuilder.Configurations.Add(new GenreMap());
            modelBuilder.Configurations.Add(new MovieArtistMap());
            modelBuilder.Configurations.Add(new MovieGenreMap());
            modelBuilder.Configurations.Add(new MovieMap());

        }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieArtist> MovieArtists { get; set; }

        public DbSet<MovieGenre> MovieGenres { get; set; }
    }
}
