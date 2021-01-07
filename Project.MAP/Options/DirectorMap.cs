using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class DirectorMap : BaseMap<Director>
    {
        public DirectorMap()
        {
            ToTable("Yönetmen");

            Property(x => x.FirstName).HasColumnName("Adı").IsRequired();
            Property(x => x.LastName).HasColumnName("Soyadı").IsRequired();
        }
    }
}
