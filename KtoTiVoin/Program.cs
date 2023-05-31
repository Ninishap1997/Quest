namespace KtoTiVoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кто ты воин?");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}? Я помню это имя. Правитель Фессалии должен носить скипетр.Отдай его своему царю в знак смирения.");
            Console.WriteLine($"Голос в голове и шило в попе: - Что ответишь этому безумцу?");
            string king = Console.ReadLine();
            Console.WriteLine($"{king} - ответ неверный.Слава Менелаю, нашему великому царю!");
            Console.WriteLine($"{name}, напиши любое значение для вручения почетной грамоты!");
            string thankYou = Console.ReadLine();
            Console.WriteLine($"Грамота - Спасибо тебе воин, {name}!");
        }
    }
}