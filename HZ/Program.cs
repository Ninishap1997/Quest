namespace HZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int count;

            Console.WriteLine("Введите число от 1 до 27");
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 27)
            {
                Console.WriteLine("Нит, введите число от 1 до 27:");
            }

            count = 0;

            for (int i = 100; i <= 999; i++)
            {
                if (i % userInput == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество трехзначных чисел, кратных {userInput} будет {count}");
        }
    }
}