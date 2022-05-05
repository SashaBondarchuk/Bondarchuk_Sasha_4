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
            Orchestra orchestra = new Orchestra();

            Console.WriteLine("Склад оркестру:");
            orchestra.Show();

            Console.WriteLine("\nЗвуки інструментів:");
            orchestra.Sounds();
        }
    }
}