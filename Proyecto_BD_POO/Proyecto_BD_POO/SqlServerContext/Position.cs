﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BD_POO.SqlServerContext
{
    public partial class Position
    {
        public Position()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string Position1 { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
