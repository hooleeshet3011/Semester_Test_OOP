using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test
{
    public abstract class Thing
    {
        public string Name { get; }

        protected Thing(string name)
        {
            Name = name;
        }

        public abstract void Print();
        public abstract int Size();
    }
}
