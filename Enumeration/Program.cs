namespace Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int step = 7;
            int startCycle = 5;
            int endCycle = 96;

            for (int i = startCycle; i <= endCycle; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}