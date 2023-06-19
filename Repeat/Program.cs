using System.Security;

namespace Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string month;
            string day;

            day = Console.ReadLine();
            switch (day)
            {
                case "Понедельник":
                    Console.WriteLine("");
                    break;
                case "Вторник":
                    Console.WriteLine("");
                    break;
                case "Среда":
                    Console.WriteLine("");
                    break;
                case "Четверг":
                    Console.WriteLine("");
                    break;
                case "Пятница":
                    Console.WriteLine("");
                    break;
                case "Суббота":
                    Console.WriteLine("");
                    break;
                case "Воскресенье":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Loh");
                    break;
            }
            month = Console.ReadLine();
            switch(month)
            {
                case "June":
                case "Jule":
                case "August":
                    Console.WriteLine("Chilll");
                    break;
                case "September":
                case "October":
                case "November":
                    Console.WriteLine("ME");
                    break;
                default:
                    Console.WriteLine("kek");
                    break;
            }*/

            /*string password;
            string Login;

            password = Console.ReadLine();
            Login = Console.ReadLine();

            if(password == "12345" || Login == "Qwerty")
            {
                Console.WriteLine("Access");
            }
            else
            {
                Console.WriteLine("Пошел вон");
            }*/

            /*int rubToUSd = 64, usdToRub = 66;
            float rub;
            float usd;
            string userInput;
            int currencyCount;

            rub = Convert.ToSingle(Console.ReadLine());
            usd = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1 - обмен валюты");
            Console.WriteLine("2 - обмен доллары на баксы");

            userInput= Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на баксы");
                    Console.WriteLine("Сколько?");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    break;
            }*/

            int age = 10;

            while (age-- > 0)
            {
                Console.WriteLine("Hello");
                if (age == 5)
                {
                    break;
                }
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}