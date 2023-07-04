using System;

namespace Charik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputName;
            char inputSymbol;
            string rectangleSymbols;
            string formattedString;

            Console.WriteLine("Введите имя");
            inputName = Console.ReadLine();

            Console.WriteLine("Введите символ");
            inputSymbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            formattedString = $"{inputSymbol}{inputName}{inputSymbol}";
            rectangleSymbols = new string(inputSymbol, formattedString.Length);

            Console.WriteLine(rectangleSymbols);
            Console.WriteLine(formattedString);
            Console.WriteLine(rectangleSymbols);
        }
    }
}