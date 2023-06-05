namespace CashForCoin
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int gold = random.Next();
            int crystalPirce = 2;

            Console.WriteLine($"Золота в инвентаре: {gold}");
            Console.WriteLine("Чтобы приобрести товар, вам необходимо обменять золото на кристаллы");
            Console.WriteLine("Какое количество кристаллов вы хотите приобрести?");

            string crystals = Console.ReadLine();
            int courseCrystals = Convert.ToInt32(crystals) * crystalPirce;
            gold -= courseCrystals;

            Console.WriteLine("Поздравляю! Вы купили разрабам обед из омаров!");
            Console.WriteLine($"Ваш баланс: кристаллы {crystals}, золото {gold}!");
        }
    }
}