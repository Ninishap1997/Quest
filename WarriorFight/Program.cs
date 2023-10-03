namespace WarriorFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandEmperorFury = "1";
            const string CommandCharge = "2";
            const string CommandEmperorLight = "3";
            const string CommandOrbitalBombardment = "4";

            Random random = new Random();
            float healthHeretic = random.Next(350,650);
            float damageHeretic = random.Next(25,80);
            float healthForceCommander = random.Next(250, 750);
            float manaForceCommander = random.Next(100, 350);

            float damageEmperorFury = random.Next(50, 71);
            float damageCharge = random.Next(80, 100);
            float healingLight = random.Next(20, 50);
            float damageOrbitalBombardment = random.Next(5000, 100000000);

            float manaEmperorFury = 15;
            float manaCharge = 20;
            float manaHealingLight = 25;

            bool startGame = true;
            string spell;

            Console.WriteLine("Я - капитан ордена космодесанта, готовый сражаться до последней капли крови за Империум. На моем пути встретились подлые еретики хаоса, которые хотели уничтожить нашу святую землю.");
            Console.WriteLine("В ожесточенной схватке, под выстрелы болтеров погибло много наших братьев сегодня");
            Console.WriteLine("Но наш храм не пал! И перед нами осталась последняя преграда посланная императором, чтобы проверить нашу верность ЕМУ");
            Console.WriteLine("Слава ему, ибо он объединяет нас!");
            Console.WriteLine("Перед Вами стоит только что обратившейся демон-принц. От человека уже мало, что осталось, теперь эта тварь порождение Варпа. Его нужно уничтожить");
            Console.WriteLine($"Здоровье демон-принца {healthHeretic}. Урон - {damageHeretic}");
            Console.WriteLine($"Ваше здоровье - {healthForceCommander}. Запас маны - {manaForceCommander}");
            Console.WriteLine("Ваши умения:");
            Console.WriteLine($"1 - Ярость Императора - Могуй удар силовым молотом дезинтегриующих низших демонов. Урон {damageEmperorFury}");
            Console.WriteLine($"2 - Заряд плазмы - Возьмите улучшенный, самими Адептус Механикус, плазменный пистолет и испепелите врагов Императора. Урон {damageCharge}");
            Console.WriteLine($"3 - Возниси молитву Ему и спаси свою душу от ужаса варпа. Исцеление {healingLight}");
            Console.WriteLine($"4 - Экстерминатус. Урон {damageOrbitalBombardment}");

            while (startGame) //(healthHeretic < 0 || healthForceCommander < 0 || manaForceCommander < 0)
            {
                Console.WriteLine("Нанесите удар");
                spell = Console.ReadLine();

                switch (spell)
                {
                    case CommandEmperorFury:
                        if (manaForceCommander > manaEmperorFury)
                        {
                            healthHeretic -= damageEmperorFury;
                            manaForceCommander -= manaEmperorFury;
                            healthForceCommander -= damageHeretic;
                            Console.WriteLine($"Вы нанесли {damageEmperorFury} урона");
                            Console.WriteLine($"Вы получили {damageHeretic} урона");
                            Console.WriteLine($"Здоровье демон-принца {healthHeretic}");
                            Console.WriteLine($"Ваше здоровье - {healthForceCommander}. Запас маны - {manaForceCommander}");
                        }
                        break;
                    case CommandCharge:
                        if (manaForceCommander > manaCharge)
                        {
                            healthHeretic -= damageCharge;
                            manaForceCommander -= manaCharge;
                            healthForceCommander -= damageHeretic;
                            Console.WriteLine($"Вы нанесли {damageCharge} урона");
                            Console.WriteLine($"Вы получили {damageHeretic} урона");
                            Console.WriteLine($"Здоровье демон-принца {healthHeretic}");
                            Console.WriteLine($"Ваше здоровье - {healthForceCommander}. Запас маны - {manaForceCommander}");
                        }
                        break;
                    case CommandEmperorLight:
                        if (manaForceCommander > manaHealingLight)
                        {
                            healthForceCommander += healingLight;
                            manaForceCommander -= manaHealingLight;
                            healthForceCommander -= damageHeretic;
                            Console.WriteLine($"Вы получили {damageHeretic} урона");
                            Console.WriteLine($"Здоровье демон-принца {healthHeretic}");
                            Console.WriteLine($"Ваше здоровье - {healthForceCommander}. Запас маны - {manaForceCommander}");
                        }
                        break;
                    case CommandOrbitalBombardment:
                        if (healthForceCommander > 0 && healthForceCommander < 10)
                        {
                            healthHeretic -= damageOrbitalBombardment;
                            healthForceCommander -= damageOrbitalBombardment;
                            Console.WriteLine($"Здоровье демон-принца {healthHeretic}");
                            Console.WriteLine($"Ваше здоровье - {healthForceCommander}. Запас маны - {manaForceCommander}");
                            Console.WriteLine("Враг был побежден, но гено семя сохранить, увы, не удалось.");
                            startGame = false;
                        }
                        break;
                }

                if (healthHeretic < 0)
                {
                    Console.WriteLine("Жалкий еретик отправлен обратно в варп во имя Императора!");
                    startGame = false;
                }
                else if (healthForceCommander < 0 || manaForceCommander < 0)
                {
                    Console.WriteLine("Император покинул вас");
                    startGame = false;
                }
            }
        }
    }
}