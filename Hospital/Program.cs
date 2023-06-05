namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingTimePatien = 10;
            int minutesHour = 60;

            Console.WriteLine("Рассчет времени просиживания штанов");
            Console.WriteLine("Сколько перед Вами человек?");

            string person = Console.ReadLine();
            int generalTime = Convert.ToInt32(person) * waitingTimePatien;
            int waitingMinutes = generalTime % minutesHour;
            int waitingHours = generalTime / minutesHour;

            Console.WriteLine($"Осталось ждать: {waitingHours} час {waitingMinutes} минут ");
        }
    }
}