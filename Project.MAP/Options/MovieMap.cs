using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class MovieMap : BaseMap<Movie>
    {
        public MovieMap()
        {
            ToTable("Filmler");

            Property(x => x.Title).HasColumnName("Başlık").IsRequired();
            Property(x => x.Description).HasColumnName("Aciklama").IsRequired();
        }
    }
}
