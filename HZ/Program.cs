namespace HZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int count = 0;
            int minThreeDigitNumber = 100;
            int maxThreeDigitNumber = 999;
            int minimumValue = 1;
            int maximumValue = 27;

            Console.WriteLine($"Введите число от {minimumValue} до {maximumValue}");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > minimumValue && userInput < maximumValue)
            {

                for (int i = minThreeDigitNumber; i <= maxThreeDigitNumber; i++)
                {
                    if (i % userInput == 0)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Количество трехзначных чисел, кратных {userInput} будет {count}");
            }
            else
            {
                Console.WriteLine($"Нит, введите число от {minimumValue} до {maximumValue}:");
            }
        }
    }
}