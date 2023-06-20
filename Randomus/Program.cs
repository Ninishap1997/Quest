using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace Randomus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            number = random.Next(1, 101);
            int startCycle = 1;
            int divider = 3;
            int sum = 0;

            Console.WriteLine($"Наше число {number}");
            Console.WriteLine("Разберем его");

            for (int i = startCycle; i < number; i++)
            {
                if (i % divider == 0)
                {
                    sum += i;
                    Console.WriteLine(sum);
                }
            }
        }
    }
}