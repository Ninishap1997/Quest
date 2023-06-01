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
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            surname = Console.ReadLine();
            Console.WriteLine($"Так правильно {name} {surname}");
        }
    }
}