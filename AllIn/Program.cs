namespace AllIn
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string commandCreateHero = "Create";
            const string commandStartGame = "Start";
            const string commandVolume = "1";
            const string commandGraphics = "2";
            const string commandHeroLight = "Элийцы";
            const string commandHeroDark = "Асмодиане";
            const string commandSetHeroSorcerer = "Волшебник";
            const string commandSetHeroCaster = "Заклинатель";
            const string commandSetHeroArcher = "Лучник";
            const string commandSetHeroAssasin = "Убийца";
            const string commandSetHeroHealer = "Целитель";
            const string commandSetHeroCharmer = "Чародей";
            const string commandSetHeroGuard = "Защитник";
            const string commandSetHeroGladiator = "Гладиатор";

            string setHeroName;
            string setHeroClass;
            string setHeroRace;
            string volume;
            string approvalChangeGraphics = "Yes";
            string graphicsForegroundColor;
            string mainMenu;
            string menuGraphics;

            int levelVolume = 100;
            int musicVolume = 100;
            int voiceVolume = 100;

            int sorcererStrength = 4;
            int sorcererAgility = 3;
            int sorcererIntelligence = 10;
            int sorcererHealth = 5;
            int sorcererMana = 7;

            int casterStrength = 6;
            int casterAgility = 2;
            int casterIntelligence = 9;
            int casterHealth = 5;
            int casterMana = 7;

            int archerStrength = 6;
            int archerAgility = 10;
            int archerIntelligence = 5;
            int archerHealth = 7;
            int archerMana = 3;

            int assasinStrength = 6;
            int assasinAgility = 9;
            int assasinIntelligence = 6;
            int assasinHealth = 5;
            int assasinMana = 6;

            int healerStrength = 8;
            int healerAgility = 2;
            int healerIntelligence = 6;
            int healerHealth = 8;
            int healerMana = 5;

            int charmerStrength = 8;
            int charmerAgility = 3;
            int charmerIntelligence = 5;
            int charmerHealth = 9;
            int charmerMana = 3;

            int guardStrength = 10;
            int guardAgility = 4;
            int guardIntelligence = 3;
            int guardHealth = 10;
            int guardMana = 2;

            int gladiatorStrength = 9;
            int gladiatorAgility = 5;
            int gladiatorIntelligence = 5;
            int gladiatorHealth = 9;
            int gladiatorMana = 3;

            bool startGame = true;

            Console.WriteLine("Добро пожаловать в консольные войны!");

            while(startGame)
            {
                    Console.WriteLine("Прежде чем начать игру, Вам необходимо создать персонажа, настроить звук и графку.");
                    Console.WriteLine($"Чтобы создать персонажа введите команду {commandCreateHero}");
                    Console.WriteLine($"Для настройки звука введите команду {commandVolume}");
                    Console.WriteLine($"Для настройки графики введите команду {commandGraphics}");
                    Console.WriteLine($"Чтобы начать игру введите команду {commandStartGame}");
                    mainMenu = Console.ReadLine();

                switch (mainMenu)
                {
                    case commandCreateHero:
                        Console.WriteLine("Создание нового персонажа");
                        Console.WriteLine("Выберите расу за которую будете играть.\nВнимание! Раса выбирается для аккаунта, создать персонажа другой расы будет невозможно\n");
                        Console.WriteLine($"Введите {commandHeroLight} чтобы выбрать Элийцев или {commandHeroDark} чтобы выбрать Асмодан");
                        setHeroRace = Console.ReadLine();

                        if (setHeroRace == commandHeroLight)
                        {
                            Console.WriteLine("Вы выбрали элийцев!");
                            Console.WriteLine("Введите имя персонажа");
                            setHeroName = Console.ReadLine();

                            Console.WriteLine("Выберите класс героя");
                            Console.WriteLine($"Введите {commandSetHeroSorcerer} чтобы выбрать Волшебника");
                            Console.WriteLine($"Введите {commandSetHeroCaster} чтобы выбрать Заклинателя");
                            Console.WriteLine($"Введите {commandSetHeroArcher} чтобы выбрать Лучника");
                            Console.WriteLine($"Введите {commandSetHeroAssasin} чтобы выбрать Убийцу");
                            Console.WriteLine($"Введите {commandSetHeroHealer} чтобы выбрать Целителя");
                            Console.WriteLine($"Введите {commandSetHeroCharmer} чтобы выбрать Чародея");
                            Console.WriteLine($"Введите {commandSetHeroGladiator} чтобы выбрать Гладиатора");
                            Console.WriteLine($"Введите {commandSetHeroGuard} чтобы выбрать Стража");
                            setHeroClass = Console.ReadLine();

                            switch (setHeroClass)
                            {
                                case commandSetHeroSorcerer:
                                    Console.WriteLine("Вы вырали класс \"Волшебник\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{sorcererStrength}");
                                    Console.WriteLine($"Ловкость:{sorcererAgility}");
                                    Console.WriteLine($"Интеллект:{sorcererIntelligence}");
                                    Console.WriteLine($"Здоровье:{sorcererHealth}");
                                    Console.WriteLine($"Мана:{sorcererMana}");
                                    break;

                                case commandSetHeroCaster:
                                    Console.WriteLine("Вы вырали класс \"Заклинатель\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{casterStrength}");
                                    Console.WriteLine($"Ловкость:{casterAgility}");
                                    Console.WriteLine($"Интеллект:{casterIntelligence}");
                                    Console.WriteLine($"Здоровье:{casterHealth}");
                                    Console.WriteLine($"Мана:{casterMana}");
                                    break;

                                case commandSetHeroArcher:
                                    Console.WriteLine("Вы вырали класс \"Лучник\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{archerStrength}");
                                    Console.WriteLine($"Ловкость:{archerAgility}");
                                    Console.WriteLine($"Интеллект:{archerIntelligence}");
                                    Console.WriteLine($"Здоровье:{archerHealth}");
                                    Console.WriteLine($"Мана:{archerMana}");
                                    break;

                                case commandSetHeroAssasin:
                                    Console.WriteLine("Вы вырали класс \"Убийца\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{assasinStrength}");
                                    Console.WriteLine($"Ловкость:{assasinAgility}");
                                    Console.WriteLine($"Интеллект:{assasinIntelligence}");
                                    Console.WriteLine($"Здоровье:{assasinHealth}");
                                    Console.WriteLine($"Мана:{assasinMana}");
                                    break;

                                case commandSetHeroHealer:
                                    Console.WriteLine("Вы вырали класс \"Целитель\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{healerStrength}");
                                    Console.WriteLine($"Ловкость:{healerAgility}");
                                    Console.WriteLine($"Интеллект:{healerIntelligence}");
                                    Console.WriteLine($"Здоровье:{healerHealth}");
                                    Console.WriteLine($"Мана:{healerMana}");
                                    break;

                                case commandSetHeroCharmer:
                                    Console.WriteLine("Вы вырали класс \"Чародей\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{charmerStrength}");
                                    Console.WriteLine($"Ловкость:{charmerAgility}");
                                    Console.WriteLine($"Интеллект:{charmerIntelligence}");
                                    Console.WriteLine($"Здоровье:{charmerHealth}");
                                    Console.WriteLine($"Мана:{charmerMana}");
                                    break;

                                case commandSetHeroGuard:
                                    Console.WriteLine("Вы вырали класс \"Страж\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{guardStrength}");
                                    Console.WriteLine($"Ловкость:{guardAgility}");
                                    Console.WriteLine($"Интеллект:{guardIntelligence}");
                                    Console.WriteLine($"Здоровье:{guardHealth}");
                                    Console.WriteLine($"Мана:{guardMana}");
                                    break;

                                case commandSetHeroGladiator:
                                    Console.WriteLine("Вы вырали класс \"Гладиатор\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{gladiatorStrength}");
                                    Console.WriteLine($"Ловкость:{gladiatorAgility}");
                                    Console.WriteLine($"Интеллект:{gladiatorIntelligence}");
                                    Console.WriteLine($"Здоровье:{gladiatorHealth}");
                                    Console.WriteLine($"Мана:{gladiatorMana}");
                                    break;

                                default:
                                    Console.WriteLine("Error");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы выбрали асмодиан!");
                            Console.WriteLine("Введите имя персонажа");
                            setHeroName = Console.ReadLine();

                            Console.WriteLine("Выберите класс героя");
                            Console.WriteLine($"Введите {commandSetHeroSorcerer} чтобы выбрать Волшебника");
                            Console.WriteLine($"Введите {commandSetHeroCaster} чтобы выбрать Заклинателя");
                            Console.WriteLine($"Введите {commandSetHeroArcher} чтобы выбрать Лучника");
                            Console.WriteLine($"Введите {commandSetHeroAssasin} чтобы выбрать Убийцу");
                            Console.WriteLine($"Введите {commandSetHeroHealer} чтобы выбрать Целителя");
                            Console.WriteLine($"Введите {commandSetHeroCharmer} чтобы выбрать Чародея");
                            Console.WriteLine($"Введите {commandSetHeroGladiator} чтобы выбрать Гладиатора");
                            Console.WriteLine($"Введите {commandSetHeroGuard} чтобы выбрать Стража");
                            setHeroClass = Console.ReadLine();

                            switch (setHeroClass)
                            {
                                case commandSetHeroSorcerer:
                                    Console.WriteLine("Вы вырали класс \"Волшебник\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{sorcererStrength}");
                                    Console.WriteLine($"Ловкость:{sorcererAgility}");
                                    Console.WriteLine($"Интеллект:{sorcererIntelligence}");
                                    Console.WriteLine($"Здоровье:{sorcererHealth}");
                                    Console.WriteLine($"Мана:{sorcererMana}");
                                    break;

                                case commandSetHeroCaster:
                                    Console.WriteLine("Вы вырали класс \"Заклинатель\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{casterStrength}");
                                    Console.WriteLine($"Ловкость:{casterAgility}");
                                    Console.WriteLine($"Интеллект:{casterIntelligence}");
                                    Console.WriteLine($"Здоровье:{casterHealth}");
                                    Console.WriteLine($"Мана:{casterMana}");
                                    break;

                                case commandSetHeroArcher:
                                    Console.WriteLine("Вы вырали класс \"Лучник\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{archerStrength}");
                                    Console.WriteLine($"Ловкость:{archerAgility}");
                                    Console.WriteLine($"Интеллект:{archerIntelligence}");
                                    Console.WriteLine($"Здоровье:{archerHealth}");
                                    Console.WriteLine($"Мана:{archerMana}");
                                    break;

                                case commandSetHeroAssasin:
                                    Console.WriteLine("Вы вырали класс \"Убийца\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{assasinStrength}");
                                    Console.WriteLine($"Ловкость:{assasinAgility}");
                                    Console.WriteLine($"Интеллект:{assasinIntelligence}");
                                    Console.WriteLine($"Здоровье:{assasinHealth}");
                                    Console.WriteLine($"Мана:{assasinMana}");
                                    break;

                                case commandSetHeroHealer:
                                    Console.WriteLine("Вы вырали класс \"Целитель\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{healerStrength}");
                                    Console.WriteLine($"Ловкость:{healerAgility}");
                                    Console.WriteLine($"Интеллект:{healerIntelligence}");
                                    Console.WriteLine($"Здоровье:{healerHealth}");
                                    Console.WriteLine($"Мана:{healerMana}");
                                    break;

                                case commandSetHeroCharmer:
                                    Console.WriteLine("Вы вырали класс \"Чародей\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{charmerStrength}");
                                    Console.WriteLine($"Ловкость:{charmerAgility}");
                                    Console.WriteLine($"Интеллект:{charmerIntelligence}");
                                    Console.WriteLine($"Здоровье:{charmerHealth}");
                                    Console.WriteLine($"Мана:{charmerMana}");
                                    break;

                                case commandSetHeroGuard:
                                    Console.WriteLine("Вы вырали класс \"Страж\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{guardStrength}");
                                    Console.WriteLine($"Ловкость:{guardAgility}");
                                    Console.WriteLine($"Интеллект:{guardIntelligence}");
                                    Console.WriteLine($"Здоровье:{guardHealth}");
                                    Console.WriteLine($"Мана:{guardMana}");
                                    break;

                                case commandSetHeroGladiator:
                                    Console.WriteLine("Вы вырали класс \"Гладиатор\"");
                                    Console.WriteLine($"Ваши характеристики: \nСила:{gladiatorStrength}");
                                    Console.WriteLine($"Ловкость:{gladiatorAgility}");
                                    Console.WriteLine($"Интеллект:{gladiatorIntelligence}");
                                    Console.WriteLine($"Здоровье:{gladiatorHealth}");
                                    Console.WriteLine($"Мана:{gladiatorMana}");
                                    break;

                                default:
                                    Console.WriteLine("Error");
                                    break;
                            }
                        }


                        Console.WriteLine($"Вы создали персонажа {setHeroName}");
                        Console.WriteLine($"Раса персонажа {setHeroRace}");
                        Console.WriteLine($"Класс персонажа {setHeroClass}");
                        break;

                    case commandVolume:
                        Console.WriteLine("Установите значение для общей громкости звука");
                        levelVolume = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Установите значение для громкости музыки в игре");
                        musicVolume = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Установите значение для громкости голоса в игре");
                        voiceVolume = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Вы установили следующие параметры");
                        Console.WriteLine($"Общая громкость {levelVolume}");
                        Console.WriteLine($"Громкость музыки {musicVolume}");
                        Console.WriteLine($"Громкость голоса {voiceVolume}");
                        break;

                    case commandGraphics:
                        Console.WriteLine("Перейти в новый режим Интрефейса?");
                        menuGraphics = Console.ReadLine();

                        if (menuGraphics == approvalChangeGraphics)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine("Ну и зря");
                        }
                        break;

                    case commandStartGame:
                        Console.WriteLine("Поехали!");
                        startGame = false;
                        break;
                }
            }
        }
    }
}