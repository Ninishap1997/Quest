namespace Charik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string setName;
            string setSymbol;
            string rectangleSymbols = "";

            Console.WriteLine("Введите имя");
            setName = Console.ReadLine();
            Console.WriteLine("Введите символ");
            setSymbol = Console.ReadLine();
            
            for (int i = 0; i < setName.Length + 2; i++)
            {
                rectangleSymbols += setSymbol;
            }
            Console.WriteLine(rectangleSymbols);
            Console.WriteLine($"{setSymbol}{setName}{setSymbol}");
            Console.WriteLine(rectangleSymbols);
            Console.ReadKey();
        }
    }
}