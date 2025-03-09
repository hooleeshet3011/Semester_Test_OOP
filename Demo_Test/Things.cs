using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test
{
    public abstract class Thing
    {
        string _name;
        public string Name()
        {
            return _name;
        }

        public Thing(string name)
        {
            _name = name;

        }
        public abstract void Print();
        public abstract int Size();
        
    }
}
