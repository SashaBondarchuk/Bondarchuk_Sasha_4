using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class StringInstrument : MusicalInstrument
    {
        public StringInstrument(string name, int stringCount, bool isTuned = false) : base(name)
        {
            IsTuned = isTuned;
            StringCount = stringCount;
        }
        public int StringCount { get; set; }
        public override void MakeSound()
        {
            if (IsTuned)
                Console.WriteLine($"{Name}: Трунь");
            else
            {
                Console.WriteLine($"Інструмет {Name} не налаштований! Потрібно налаштувати струн: {StringCount}");
                TuneTheInstrument();
            }
                
        }
        public override void TuneTheInstrument()
        {
            IsTuned = true;
        }
    }
}