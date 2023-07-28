namespace Skobka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depth = 0;
            int maxDepth = 0;
            string userInputSymbol;
            bool isSuccess = true;
            char symbolLeft = '(';
            char symbolRight = ')';

            while (isSuccess)
            {
                Console.WriteLine($"Нужна строка с символами, введи строку с символами {symbolLeft}, {symbolRight}");
                userInputSymbol = Console.ReadLine();

                if (userInputSymbol.Contains(symbolLeft) == false && userInputSymbol.Contains(symbolRight) == false)
                {
                    Console.WriteLine($"Гретчин! Ты не ввел строку с символами {symbolLeft}, {symbolRight}");
                    return;
                }

                foreach (char symbol in userInputSymbol)
                {
                    if (symbolLeft == symbol)
                    {
                        depth++;

                        if (depth > maxDepth)
                        {
                            maxDepth = depth;
                        }
                    }
                    else if (symbolRight == symbol)
                    {
                        if (depth < 0)
                        {
                            Console.WriteLine($"Гретчин! Ты не ввел строку с символами {userInputSymbol}");
                            isSuccess = false;
                            break;
                        }

                        depth--;

                    }
                    else
                    {
                        Console.WriteLine($"Гретчин! Строка может содержать только символы {symbolLeft}, {symbolRight}");
                        isSuccess = false;
                        break;
                    }
                }

                if (depth == 0)
                {
                    Console.WriteLine($"Молодец, твоя строка - {userInputSymbol}, глубина - {maxDepth}");
                    isSuccess = false;
                }
            }
        }
    }
}