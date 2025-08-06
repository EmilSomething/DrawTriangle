using System.Security.Cryptography;

namespace ConsoleApp2
{
    internal class Program
    {
        static void starPrinter(int starRows)
        {
            for (int i = 1; i <= starRows; i++)
            {
                string starString = new string('*', i * 2 - 1);
                Console.WriteLine(starString.PadLeft(starRows + i - 1));
            }
        }

        static void Main(string[] args)
        {
            starPrinter(10);

        }
    }
}
