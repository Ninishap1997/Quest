namespace Pasword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandWhaaghHumanity = "1";
            const string CommandWhaaghGorka = "2";
            const string CommandWhaaghMorka = "3";
            const string CommandSellPlane = "4";

            Random random = new Random();
            int costFang = random.Next();
            string password = "Password";
            string passwordInput;
            string warBossCommand;
            string warBossChoiseBigBird = "Штука";
            string warBossChoiseFang = "Зубы";
            string warBossChoise;
            int attemptsSystem = 5;
            int userAttempts = 0;

            for (int i = userAttempts; userAttempts < attemptsSystem; attemptsSystem--)
            {
                Console.WriteLine("Введите пароль");
                passwordInput = Console.ReadLine();

                if (passwordInput != password)
                {
                    Console.WriteLine("Введен неверный пароль");
                    Console.WriteLine($"Осталось попыток {attemptsSystem - 1}");
                }
                else
                {
                    Console.WriteLine("Бомбовоз заправлен");
                    Console.WriteLine("Босс, кого стукать будем?");
                    Console.WriteLine($"Ваш приказ: {CommandSellPlane}, {CommandWhaaghGorka}, {CommandWhaaghHumanity}, {CommandWhaaghMorka}");
                    warBossCommand = Console.ReadLine();

                        switch (warBossCommand)
                        {
                            case CommandWhaaghHumanity:
                                Console.WriteLine("Ми будим стукать людишей, заряжай свинцометы!");
                                break;
                            case CommandWhaaghGorka:
                                Console.WriteLine("ГОРКА НЕ МОРКА ЗЕЛЕНОГОЛОВЫЙ!");
                                break;
                            case CommandWhaaghMorka:
                                Console.WriteLine("НЕТ МОРКА НЕ ГОРКА!");
                                break;
                            case CommandSellPlane:
                                Console.WriteLine("Большая птица или большой клык?");
                            Console.WriteLine($"Ваш приказ: {warBossChoiseBigBird} или {warBossChoiseFang}?");
                            warBossChoise = Console.ReadLine();
                                
                                if(warBossChoise == warBossChoiseBigBird)
                                {
                                    Console.WriteLine("Где моя тачка, я не люблю ходить пешком?");
                                }
                                else
                                {
                                    Console.WriteLine("Мне нужны их зубыы не повредите зубыыы");
                                    Console.WriteLine($"Тупоголовый гретчин продал последний бомбовоз за {costFang} зубов");
                                }
                                break;
                        }
                    break;
                }
            }
        }
    }
}