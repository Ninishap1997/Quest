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
            char leftBracket = '(';
            char rightBracket = ')';

            while (isSuccess)
            {
                Console.WriteLine($"Нужна строка с символами, введи строку с символами {leftBracket}, {rightBracket}");
                userInputSymbols = Console.ReadLine(); 

                if (userInputSymbols.Contains(leftBracket) == false && userInputSymbols.Contains(rightBracket) == false)
                {
                    Console.WriteLine($"Гретчин! Ты не ввел строку с символами {leftBracket}, {rightBracket}");
                    return;
                }

                foreach (char symbol in userInputSymbols)
                {
                    if (leftBracket == symbol)
                    {
                        depth++;

                        if (depth > maxDepth)
                        {
                            maxDepth = depth;
                        }
                    }
                    else if (rightBracket == symbol)
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
                        Console.WriteLine($"Гретчин! Строка может содержать только символы {leftBracket}, {rightBracket}");
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