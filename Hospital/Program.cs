namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeWaiting = 10;
            int minutesInAnHour = 60;

            Console.WriteLine("Рассчет времени просиживания штанов");
            Console.WriteLine("Сколько перед Вами человек?");

            string person = Console.ReadLine();
            int generalTime = Convert.ToInt32(person) * timeWaiting;
            int timeMinuteWaiting = generalTime % minutesInAnHour;
            int timeHourWaiting = generalTime / minutesInAnHour;

            Console.WriteLine($"Осталось ждать: {timeHourWaiting} час {timeMinuteWaiting} минут ");
        }
    }
}