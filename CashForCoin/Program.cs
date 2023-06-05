namespace CashForCoin
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random number = new Random();
            int gold = number.Next();

            Console.WriteLine($"Золота в инвентаре: {gold}");
            Console.WriteLine("Чтобы приобрести товар, вам необходимо обменять золото на кристаллы");
            Console.WriteLine("Какое количество кристаллов вы хотите приобрести?");

            string crystal = Console.ReadLine();
            int courseCrystal = Convert.ToInt32(crystal) * 2;  //Курс: 1 кристалл = 2 единицам золота
            gold = gold - courseCrystal;

            Console.WriteLine("Поздравляю! Вы купили разрабам обед из омаров!");
            Console.WriteLine($"Ваш баланс: кристаллы {crystal}, золото {gold}!");
        }
    }
}