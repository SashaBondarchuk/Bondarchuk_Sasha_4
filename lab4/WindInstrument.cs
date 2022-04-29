using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class WindInstrument : MusicalInstrument
    {
        public WindInstrument(string name, bool isTuned = false) : base(name)
        {
            IsTuned = isTuned;
        }
        
        public override void MakeSound()
        {
            if (IsTuned)
                Console.WriteLine($"{Name}: Тру-ту-ту");
            else
            {
                Console.WriteLine($"Інструмет {Name} не налаштований!");
                TuneTheInstrument();
            }

        }
        public override void TuneTheInstrument()
        {
            IsTuned = true;
        }
    }
}