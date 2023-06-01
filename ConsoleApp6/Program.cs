namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Грозный";
            string secondName = "Иван";
            Console.WriteLine($"Так неправильно {name} {secondName}");
            name = "Иван";
            secondName = "Грозный";
            Console.WriteLine($"Так правильно {name} {secondName}");
        }
    }
}