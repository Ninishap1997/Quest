namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingTimePatient = 10;
            int minutesInHour = 60;

            Console.WriteLine("Рассчетное время высадки");
            Console.WriteLine("Сколько перед Вами человек?");

            string persons = Console.ReadLine();
            int generalTime = Convert.ToInt32(persons) * waitingTimePatient;
            int waitingMinutes = generalTime % minutesInHour;
            int waitingHours = generalTime / minutesInHour;

            Console.WriteLine($"Осталось ждать: {waitingHours} час {waitingMinutes} минут ");
        }
    }
}