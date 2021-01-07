﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class GenreMap : BaseMap<Genre>
    {
        public GenreMap()
        {
            ToTable("Tür");

            Property(x => x.Title).HasColumnName("Başlık").IsRequired();
        }
    }
}
