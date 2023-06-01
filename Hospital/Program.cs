namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waiting = 10;
            Console.WriteLine("Рассчет времени просиживания штанов");
            Console.WriteLine("Сколько перед Вами человек?");
            var person = Console.ReadLine();
            var generalTime = Convert.ToInt64(person) * waiting;
            var timeMinute = generalTime % 60;
            var timeHour = generalTime / 60;
            Console.WriteLine($"Осталось ждать: {timeHour} час {timeMinute} минут ");
        }
    }
}