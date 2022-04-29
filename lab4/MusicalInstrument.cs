using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class MusicalInstrument
    {
        public string Name { get; set; }
        public bool IsTuned { get; set; }

        public MusicalInstrument(string name)
        {
            Name = name;
        }
        
        abstract public void TuneTheInstrument();
        abstract public void MakeSound();
        public void ShowInfo()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}