using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tren
{
    public class Program
    {
        public static async Task Main()
        {
            const string CommandExit = "exit";
            const string CommandBuyRubForUsd = "1";
            const string CommandBuyRubForEur = "2";
            const string CommandBuyUsdForRub = "3";
            const string CommandBuyUsdForEur = "4";
            const string CommandBuyEurForRub = "5";
            const string CommandBuyEurForUsd = "6";


            var client = new HttpClient();
            var url = "https://www.cbr-xml-daily.ru/daily_json.js";
            var responseString = await client.GetStringAsync(url);
            var exchangeRates = Newtonsoft.Json.JsonConvert.DeserializeObject<ExchangeRates>(responseString);

            decimal usdRateToRub = exchangeRates.Valute.USD.Value;
            decimal eurRateToRub = exchangeRates.Valute.EUR.Value;
            decimal eurRateToUsd = 20M;
            decimal rubRateToUsd = 30M;
            decimal usdRateToEur = 40M;
            decimal rubRateToEur = 50M;
            decimal rubBalance = 0;
            decimal usdBalance = 0;
            decimal eurBalance = 0;
            decimal rubInputRate;
            decimal usdInputRate;
            decimal eurInputRate;
            decimal rubConvert;
            decimal usdConvert;
            decimal eurConvert;
            string commandStart = "start";
            string mainMenu;
            string userChoice = null;
            bool exitProgramm = true;
            DateTime dateToday = DateTime.Now;


            Console.WriteLine("Дратути!");
            Console.WriteLine($"Данный конвертер валют основан на данных ЦБ РФ от {dateToday}");
            Console.WriteLine("Чтобы начать работу, введите команду \"start\"");

            while (userChoice != commandStart)
            {
                userChoice = Console.ReadLine();

                if (userChoice == commandStart)
                {
                    Console.WriteLine("Добро пожаловать в онлайн конвертер!");
                    Console.WriteLine("Мы предосталвяем возможность работы со следующими валютами: Евро, Доллар США");
                    Console.WriteLine("На данный момент мы имеем следующие курсы валют:");
                    Console.WriteLine($"Курс Евро: {eurRateToRub} руб.");
                    Console.WriteLine($"Курс Доллар США: {usdRateToRub} руб.");

                    Console.WriteLine("Сколько рублей вы хотите внести на счет?");
                    rubBalance = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Сколько евро вы хотите внести на счет?");
                    eurBalance = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Сколько долларов вы хотите внести на счет?");
                    usdBalance = Convert.ToDecimal(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Чтобы начать работу, введите команду \"start\"");
                }
            }

            while (exitProgramm)
            {
                Console.WriteLine($"Баланс в рублях: {rubBalance}");
                Console.WriteLine($"Баланс в долларах: {usdBalance}");
                Console.WriteLine($"Баланс в евро: {eurBalance}");

                Console.WriteLine("Введите следующую команду для пополнения счета:");
                Console.WriteLine($"Введите команду {CommandBuyRubForUsd} для покупки рублей за доллары");
                Console.WriteLine($"Введите команду {CommandBuyRubForEur} для покупки  рублей за евро");

                Console.WriteLine($"Введите команду {CommandBuyUsdForRub} для покупки долларов за рубли");
                Console.WriteLine($"Введите команду {CommandBuyUsdForEur} для покупки долларов за евро");

                Console.WriteLine($"Введите команду {CommandBuyEurForRub} для покупки  евро за рубли");
                Console.WriteLine($"Введите команду {CommandBuyEurForUsd} для покупки евро за доллары");;

                Console.WriteLine($"Введите команду {CommandExit} для выхода из программы");
                mainMenu = Console.ReadLine();

                switch (mainMenu)
                {
                    case CommandBuyUsdForRub:
                        Console.WriteLine("Сколько долларов за рубли Вы хотите купить?");
                        usdInputRate = Convert.ToDecimal(Console.ReadLine());
                        rubConvert = usdInputRate * usdRateToRub;

                        if (rubConvert > rubBalance)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            usdBalance += rubConvert;
                            rubBalance -= usdInputRate;
                        }
                        break;

                    case CommandBuyEurForRub:
                        Console.WriteLine("Сколько евро за рубли Вы хотите купить?");
                        eurInputRate = Convert.ToDecimal(Console.ReadLine());
                        rubConvert = eurInputRate * eurRateToRub;

                        if (rubConvert > rubBalance)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            eurBalance += rubConvert;
                            rubBalance -= eurInputRate;
                        }
                        break;

                    case CommandBuyRubForUsd:
                        Console.WriteLine("Сколько рублей за доллары Вы хотите купить?");
                        rubInputRate = Convert.ToDecimal(Console.ReadLine());
                        usdConvert = rubInputRate * usdRateToRub;

                        if (usdConvert > usdBalance)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            rubBalance += usdConvert;
                            usdBalance -= rubInputRate;
                        }
                        break;

                    case CommandBuyRubForEur:
                        Console.WriteLine("Сколько рублей за евро Вы хотите купить?");
                        eurInputRate = Convert.ToDecimal(Console.ReadLine());
                        eurConvert = eurInputRate * eurRateToRub;

                        if (eurConvert > eurBalance)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            rubBalance += eurConvert;
                            eurBalance -= eurInputRate;
                        }
                        break;

                    case CommandBuyEurForUsd:
                        Console.WriteLine("Сколько евро за доллары Вы хотите купить?");
                        usdInputRate = Convert.ToDecimal(Console.ReadLine());
                        usdConvert = usdInputRate * eurRateToUsd;

                        if(usdConvert > usdBalance)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            eurBalance += usdConvert;
                            usdBalance -= usdConvert;
                        }
                        break;

                    case CommandBuyUsdForEur:
                        Console.WriteLine("Сколько долларов за евро Вы хотите купить?");
                        eurInputRate = Convert.ToDecimal(Console.ReadLine());
                        eurConvert = eurInputRate * usdRateToEur;

                        if (eurConvert > eurBalance)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            usdBalance += eurConvert;
                            eurBalance -= eurConvert;
                        }
                        break;

                    case CommandExit:
                        Console.WriteLine("Датвидути");
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }

            }
        }
    }
}

    public class ExchangeRates
    {
        public Valute Valute { get; set; }
    }

    public class Valute
    {
        public USD USD { get; set; }
        public EUR EUR { get; set; }
    }

    public class USD
    {
        public decimal Value { get; set; }
    }
    
    public class EUR
    {
        public decimal Value { get; set; }
    }
