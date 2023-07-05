namespace Skobka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depth = 0;
            int maxDepth = 0;
            string inputUser;
            
            Console.WriteLine("Введите текст из любого количества символов '(' и ')'\n");

            inputUser = Console.ReadLine();

            foreach (char symbol in inputUser)
            {
                if (symbol == '(')
                {
                    depth++;

                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }
                }
                else if (symbol == ')')
                {
                    depth--;
                    if (depth < 0)
                    {
                        Console.WriteLine("ОШИБКА");
                        return;
                    }
                }
            }

            if (depth != 0)
            {
                Console.WriteLine("ОШИБКА");
                return;
            }
            Console.WriteLine("Корректное выражение, максимальная глубина: " + maxDepth);
        }
    }
}