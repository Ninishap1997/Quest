using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tren
{
    public class Program
    {
        public static async Task Main()
        {
            const string CommandExit = "exit";
            const string CommandOne = "1";
            const string CommandTwo = "2";
            const string CommandTree = "3";

            var client = new HttpClient();
            var url = "https://www.cbr-xml-daily.ru/daily_json.js";
            var responseString = await client.GetStringAsync(url);
            var exchangeRates = Newtonsoft.Json.JsonConvert.DeserializeObject<ExchangeRates>(responseString);

            string CommandStart = "start";
            decimal usdRate = exchangeRates.Valute.USD.Value;
            decimal eurRate = exchangeRates.Valute.EUR.Value;
            decimal aedRate = exchangeRates.Valute.AED.Value;
            decimal rubBalance = 500000;
            decimal usdBalance = 500000;
            decimal eurBalance = 500000;
            decimal aedBalance = 500000;
            decimal usdInputRate;
            decimal eurInputRate;
            decimal aedInputRate;
            decimal usdConvert;
            decimal eurConvert;
            decimal aedConvert;
            string userChoice = null;
            string rateOff;
            DateTime dateToday = DateTime.Now;

            Console.WriteLine("Дратути!");
            Console.WriteLine($"Данный конвертер валют основан на данных ЦБ РФ от {dateToday}");
            Console.WriteLine("Чтобы начать работу, введите команду \"start\"");

            while (userChoice != CommandStart)
            {
                userChoice = Console.ReadLine();

                if (userChoice == CommandStart)
                {
                    Console.WriteLine("Добро пожаловать в онлайн конвертер!");
                    Console.WriteLine("Мы предосталвяем возможность работы со следующими валютами: Евро, Доллар США, Дирхам ОАЭ");
                    Console.WriteLine("На данный момент мы имеем следующие курсы валют:");
                    Console.WriteLine($"Курс Дирхам ОАЭ: {aedRate} руб.");
                    Console.WriteLine($"Курс Евро: {eurRate} руб.");
                    Console.WriteLine($"Курс Доллар США: {usdRate} руб.");
                }
                else
                {
                    Console.WriteLine("Чтобы начать работу, введите команду \"start\"");
                }
            }

            Console.WriteLine("Если вы хотите приобрести Доллар США - введите цифру 1");
            Console.WriteLine("Если вы хотите приобрести Евро - введите цифру 2");
            Console.WriteLine("Если вы хотите приобрести Дирхам ОАЭ - введите цифру 3");
            Console.WriteLine("Если вы хотите выйти из программы - введите \"exit\"");

            userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case CommandOne:
                        Console.WriteLine("Сколько Долларов США Вы хотите купить?");

                        usdInputRate = Convert.ToDecimal(Console.ReadLine());
                        usdConvert = usdInputRate * usdRate;

                        if (usdConvert > rubBalance)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            usdBalance = usdBalance + usdInputRate;
                            rubBalance = rubBalance - usdConvert;

                            Console.WriteLine($"Ваш кошелек: Доллар США {usdBalance}, Рубль {rubBalance}");
                        }
                        break;
                    case CommandTwo:
                        Console.WriteLine("Сколько Евро Вы хотите купить?");

                        eurInputRate = Convert.ToDecimal(Console.ReadLine());
                        eurConvert = eurInputRate * eurRate;

                        if (eurConvert > rubBalance)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            eurBalance = eurBalance + eurInputRate;
                            rubBalance = rubBalance - eurConvert;

                            Console.WriteLine($"Ваш кошелек: Евро {eurBalance}, Рубль {rubBalance}");
                        }
                        break;
                    case CommandTree:
                        Console.WriteLine("Сколько Дирхам ОАЭ Вы хотите купить?");

                        aedInputRate = Convert.ToDecimal(Console.ReadLine());
                        aedConvert = aedInputRate * aedRate;

                        if (aedConvert > rubBalance)
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            aedBalance = aedBalance + aedInputRate;
                            rubBalance = rubBalance - aedConvert;

                            Console.WriteLine($"Ваш кошелек: Дирхам ОАЭ {aedBalance}, Рубль {rubBalance}");
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

    public class ExchangeRates
    {
        public Valute Valute { get; set; }
    }

    public class Valute
    {
        public USD USD { get; set; }
        public EUR EUR { get; set; }
        public AED AED { get; set; }
    }

    public class USD
    {
        public decimal Value { get; set; }
    }
    
    public class EUR
    {
        public decimal Value { get; set; }
    }

    public class AED
    {
        public decimal Value { get; set; }
    }