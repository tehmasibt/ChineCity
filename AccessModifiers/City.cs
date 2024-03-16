using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class City
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                
               if(NameDeyer(value)) _name = value;
                
            }
        }
        public bool NameDeyer(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else
            {
                foreach (var item in value)
                {
                    if (char.IsLetter(item))
                    {
                        return true;
                    }
                }
            }
            if (!(value.Length > 3 && value.Length < 20))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        protected int _population;
        public virtual int Population
        {
            get
            {
                return _population;
            }
            set 
            {
                if(value < 0)
                {
                    Console.WriteLine("0-dan kicik yeni menfi sayda insan olmur");
                    return;
                }   
                _population = value;
            }
        }

    }
}
