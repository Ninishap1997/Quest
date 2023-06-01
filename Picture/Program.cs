namespace Picture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictureFull = 52 / 3;
            int pictureOst = 52 % 3;
            Console.WriteLine($"Столько рядов будет заполнено полностью {pictureFull}");
            Console.WriteLine($"Остаток - {pictureOst}");
        }
    }
}