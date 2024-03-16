using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class ChineCity:City
    {
        public override int Population 
        {
            get
            {
                return _population;
            }
            set
            {
                if(value<100000)
                {
                    Console.WriteLine("population 100000 kicik ola bilmez");
                    return;
                }
                _population = value;
            }
             
        }
        
    }
}
