using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo_Test
{
    public class Folder : Thing
    {
        private List<Thing> _contents;

        public Folder(string name) : base(name)
        {
            _contents = new List<Thing>();
        }

        public void Add(Thing toAdd)
        {
            _contents.Add(toAdd);
        }

        public override int Size()
        {
            int totalSize = 0;
            foreach (Thing item in _contents)
            {
                totalSize += item.Size();
            }
            return totalSize;
        }

        public override void Print()
        {
            Console.WriteLine($"The Folder: '{Name}' contains:");
            foreach (Thing item in _contents)
            {
                item.Print();
            }
        }
    }
}

