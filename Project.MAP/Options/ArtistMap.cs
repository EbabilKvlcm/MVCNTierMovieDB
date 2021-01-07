using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Models;

namespace Project.MAP.Options
{
    public class ArtistMap : BaseMap<Artist>
    {
        public ArtistMap()
        {
            ToTable("Oyuncular");

            Property(x => x.FirstName).HasColumnName("Adı").IsRequired();
            Property(x => x.LastName).HasColumnName("Soyadı").IsRequired();
        }
    }
}
