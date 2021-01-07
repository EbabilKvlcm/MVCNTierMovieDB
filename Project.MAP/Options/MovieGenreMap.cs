using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class MovieGenreMap : BaseMap<MovieGenre>
    {
        public MovieGenreMap()
        {
            Ignore(x => x.ID);

            HasKey(x => new { x.GenreID, x.MovieID });

            ToTable("Film Türü");
        }
    }
}
