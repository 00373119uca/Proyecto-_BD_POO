﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_BD_POO.SqlServerContext
{
    public partial class Disease
    {
        public int Id { get; set; }
        public int? DuiCitizen { get; set; }
        public string Disease1 { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
    }
}
