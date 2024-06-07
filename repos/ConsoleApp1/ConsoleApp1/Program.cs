using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lets learn C#";
            Console.WindowHeight= 30;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("whats is your name?");
            Console.ReadLine(); 
            Console.ReadKey();
        }
    }
}
