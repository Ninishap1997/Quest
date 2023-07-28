namespace Skobka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depth = 0;
            int maxDepth = 0;
            string userInputSymbols;
            bool isSuccess = true;
            char leftSymbol = '(';
            char rightSymbol = ')';

            while (isSuccess)
            {
                Console.WriteLine($"Нужна строка с символами, введи строку с символами {leftSymbol}, {rightSymbol}");
                userInputSymbols = Console.ReadLine();

                if (userInputSymbols.Contains(leftSymbol) == false && userInputSymbols.Contains(rightSymbol) == false)
                {
                    Console.WriteLine($"Гретчин! Ты не ввел строку с символами {leftSymbol}, {rightSymbol}");
                    return;
                }

                foreach (char symbol in userInputSymbols)
                {
                    if (leftSymbol == symbol)
                    {
                        depth++;

                        if (depth > maxDepth)
                        {
                            maxDepth = depth;
                        }
                    }
                    else if (rightSymbol == symbol)
                    {
                        if (depth < 0)
                        {
                            Console.WriteLine($"Гретчин! Ты не ввел строку с символами {userInputSymbols}");
                            isSuccess = false;
                            break;
                        }

                        depth--;
                    }
                    else
                    {
                        Console.WriteLine($"Гретчин! Строка может содержать только символы {leftSymbol}, {rightSymbol}");
                        isSuccess = false;
                        break;
                    }
                }

                if (depth == 0)
                {
                    Console.WriteLine($"Молодец, твоя строка - {userInputSymbols}, глубина - {maxDepth}");
                    isSuccess = false;
                }
            }
        }
    }
}