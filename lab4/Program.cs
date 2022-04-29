using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicalInstrument[] Orchestra = new MusicalInstrument[]
            {
                new PercussionInstrument(name: "Барабан"),
                new PercussionInstrument(name: "Великий барабан"),
                new StringInstrument(name: "Гітара", isTuned: false, stringCount: 6),
                new WindInstrument(name: "Сопілка"/*, isTuned: true*/),
                new WindInstrument(name: "Саксофон", isTuned: true)
            };
            
            Console.WriteLine("Склад оркестру:");
            foreach (var musicalinstrument in Orchestra)
            {
                musicalinstrument.ShowInfo();
            }

            Console.WriteLine("\nЗвуки інструментів:");
            foreach (var musicalinstrument in Orchestra)
            {
                musicalinstrument.MakeSound();
            }
        }
    }
}