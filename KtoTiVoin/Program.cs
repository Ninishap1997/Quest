namespace KtoTiVoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInRow = 3;
            int totalPictures = 52;

            int completedRows = totalPictures / picturesInRow;
            int remainPictures = totalPictures % picturesInRow;

            Console.WriteLine($"Заполнено рядов {completedRows}");
            Console.WriteLine($"Остаток {remainPictures}");
        }
    }
} 