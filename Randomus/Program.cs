using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace Randomus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int minRandomNumber = 0;
            int maxRandomNumber = 101;
            int startCycle = 1;
            int divider = 3;
            int sum = 0;

            Random random = new Random();
            number = random.Next(minRandomNumber, maxRandomNumber);
            Console.WriteLine($"Наше число {number}");
            Console.WriteLine("Разберем его");

            for (int i = startCycle; i <= number; i++)
            {
                if (i % divider == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"Подведем итог: Сумма чисел, числа {number} кратных {divider} равна {sum}");
        }
    }
}