using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Movie:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int DirectorID { get; set; }

        //Relationals Properties

        public virtual Director Director { get; set; }
        public virtual List<MovieArtist> MovieArtists { get; set; }
        public virtual List<MovieGenre> MovieGenres { get; set; }
    }
}
