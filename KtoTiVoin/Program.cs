namespace KtoTiVoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 3;
            int picture = 52;
            int pictureMax = picture / row;
            int remains = picture % row;
            Console.WriteLine($"Заполнено рядов {pictureMax}");
            Console.WriteLine($"Остаток {remains}");
        }
    }
}