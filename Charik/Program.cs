using System;

namespace Charik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputName;
            string rectangleSymbols;
            char inputSymbol;
            

            Console.WriteLine("Введите имя");
            inputName = Console.ReadLine();

            Console.WriteLine("Введите символ");
            inputSymbol = (char)Console.Read();

            rectangleSymbols = new string(inputSymbol, inputName.Length + 2);

            Console.WriteLine(rectangleSymbols);
            Console.Write(inputSymbol);
            Console.Write(inputName);
            Console.WriteLine(inputSymbol);
            Console.WriteLine(rectangleSymbols);

            /*string name;
            string symbol;
            string rectangleSymbols = "";

            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            symbol = Console.ReadLine();
            
            for (int i = 0; i < name.Length + 2; i++)
            {
                rectangleSymbols += symbol;
            }
            Console.WriteLine(rectangleSymbols);
            Console.WriteLine($"{symbol}{name}{symbol}");
            Console.WriteLine(rectangleSymbols);
            Console.ReadKey();*/
        }
    }
}