﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_4.Interfacee
{
    internal interface SeriesBy3
    {
        public int current { get; set; }

        public void GetNext()
        {
            current += 3;
        }
    }
}
