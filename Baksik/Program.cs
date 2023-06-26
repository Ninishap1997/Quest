using Baksik.Models;
using System.Text.Json;

namespace Baksik
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            const string CommandStart = "start";
            const string CommandExit = "exit";
            const string CommandRepeat = "repeat";

            decimal dollarAccount;
            decimal rubAccount;
            decimal renminbeAccount;
 
                using var httpClient = new HttpClient();

                var url = "https://www.cbr-xml-daily.ru/daily_json.js";
                var responseString = await httpClient.GetStringAsync(url);
                var currencyRates = JsonSerializer.Deserialize<Rates>(responseString);

                Console.WriteLine($"USD: {currencyRates.USD} RUB");
                Console.WriteLine($"EUR: {currencyRates.EUR} RUB");

        }
    }

}