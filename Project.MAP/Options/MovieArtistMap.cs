using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class MovieArtistMap : BaseMap<MovieArtist>
    {
        public MovieArtistMap()
        {
            ToTable("Film Oyuncuları");

            Ignore(x => x.ID);

            HasKey(x => new { x.ArtistID, x.MovieID });
        }
    }
}
