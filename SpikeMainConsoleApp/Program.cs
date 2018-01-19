using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeMainConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Good day, ");
            Console.Write(name);
            Console.WriteLine("!");

        }
    }
}
