namespace Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int step = 7;

            for (int i = 5; i < 100; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}