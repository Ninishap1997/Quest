namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Грозный";
            string surname = "Иван";

            Console.WriteLine($"Так неправильно {name} {surname}");
            Console.WriteLine("Необходимо исправить ошибку.");

            string replacement = name;
            name = surname;
            surname = replacement;

            Console.WriteLine($"Так правильно {name} {surname}");
        }
    }
}