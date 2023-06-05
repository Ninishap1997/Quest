namespace KtoTiVoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesRow = 3;
            int totalPictures = 52;

            int completedZone = totalPictures / picturesRow;
            int remainPictures = totalPictures % picturesRow;

            Console.WriteLine($"Заполнено рядов {completedZone}");
            Console.WriteLine($"Остаток {remainPictures}");
        }
    }
} 