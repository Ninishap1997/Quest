namespace Skobka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depth = 0;
            int maxDepth = 0;
            string userInputSymbol;

            Console.WriteLine("Нужна строка с символами, введи строку с символами '(' и ')'");
            userInputSymbol = Console.ReadLine();

            if (!userInputSymbol.Contains('(') && !userInputSymbol.Contains(')'))
            {
                Console.WriteLine("Гретчин! Ты не ввел строку с символами '(', ')'");
                return;
            }

            foreach (char symbol in userInputSymbol)
            {
                if (symbol == '(')
                {
                    depth++;
                    maxDepth = Math.Max(maxDepth, depth);
                }
                else if (symbol == ')')
                {
                    if (depth == 0)
                    {
                        Console.WriteLine($"Гретчин! Ты не ввел строку с символами {userInputSymbol}");
                        return;
                    }
                    depth--;
                }
                else
                {
                    Console.WriteLine("Ошибка! Строка может содержать только символы '(', ')'");
                    return;
                }
            }

            if (depth == 0)
            {
                Console.WriteLine($"Молодец, твоя строка - {userInputSymbol}, глубина - {maxDepth}");
            }
            else
            {
                Console.WriteLine($"Гретчин! Неверная строка {userInputSymbol}");
            }
        }
    }
}