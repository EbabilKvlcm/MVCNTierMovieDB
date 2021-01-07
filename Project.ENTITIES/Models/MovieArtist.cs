using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class MovieArtist:BaseEntity
    {
        public int MovieID { get; set; }
        public int ArtistID { get; set; }

        //Relationals Properties

        public virtual Movie Movie { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
