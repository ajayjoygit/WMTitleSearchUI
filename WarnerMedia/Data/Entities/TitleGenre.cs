﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarnerMedia.Data.Entities
{
    public class TitleGenre
    {
        public int Id { get; set; }
        public Title Title { get; set; }

        public Genre Genre { get; set; }
    }
}
