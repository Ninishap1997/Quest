namespace KtoTiVoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictureFull = 52 / 3;
            double pictureOst = 52.0 % 3.0;
            Console.WriteLine($"Заполнено рядов {pictureFull}");
            Console.WriteLine($"Остаток {pictureOst}");
        }
    }
}