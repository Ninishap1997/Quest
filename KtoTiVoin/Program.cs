﻿namespace KtoTiVoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictureFull = 52 / 3;
            int pictureOst = 52 % 3;
            Console.WriteLine($"Заполнено рядов {pictureFull}");
            Console.WriteLine($"Остаток {pictureOst}");

            string name = "Грозный";
            string secondName = "Иван";
            Console.WriteLine($"Так неправильно {name} {secondName}");
            name = "Иван";
            secondName = "Грозный";
            Console.WriteLine($"Так правильно {name} {secondName}");
        }
    }
}