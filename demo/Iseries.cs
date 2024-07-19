using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_4.Interfacee
{
    internal interface  Iseries
    {
        public int Current { get; set; }
        public void GetNext();
        public void ReSet()
        {
            Current = 0;
        }
        
    }
}
