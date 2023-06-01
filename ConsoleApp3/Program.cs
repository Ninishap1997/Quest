using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Грозный";
            string secondName = "Иван";
            Console.WriteLine($"Так неправильно {name} {secondName}");
            name = "Иван";
            secondName = "Грозный";
            Console.WriteLine($"Так правильно {name} {secondName}");
        }
    }
}
