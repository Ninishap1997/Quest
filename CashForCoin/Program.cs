namespace CashForCoin
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Курс: 1 кристалл = 2 единицам золота
            Random chislo = new Random();
            var gold = chislo.Next();
            Console.WriteLine($"Золота в инвентаре: {gold}");
            Console.WriteLine("Чтобы приобрести товар, вам необходимо обменять золото на кристаллы");
            Console.WriteLine("Какое количество кристаллов вы хотите приобрести?");
            var kristall = Console.ReadLine();
            var courseKristall = Convert.ToInt64(kristall) * 2;
            var balance = gold - courseKristall;
            Console.WriteLine("Поздравляю! Вы купили разрабам обед из омаров!");
            Console.WriteLine($"Ваш баланс: кристаллы {kristall}, золото {balance}!");
        }
    }
}