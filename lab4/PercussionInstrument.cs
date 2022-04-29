using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class PercussionInstrument : MusicalInstrument
    {
        public PercussionInstrument(string name, bool isTuned = true) : base(name)
        {
            IsTuned = isTuned;
        }
        
        public override void MakeSound()
        {
            if (IsTuned)
                Console.WriteLine($"{Name}: Бум");
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