namespace KtoTiVoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zonePicture = 3;
            int totalPictures = 52;
            int completedZone = totalPictures / zonePicture;
            int remainsPicture = totalPictures % zonePicture;

            Console.WriteLine($"Заполнено рядов {completedZone}");
            Console.WriteLine($"Остаток {remainsPicture}");
        }
    }
} 