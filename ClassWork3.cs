using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Convert.ToString(Console.ReadLine());
            int one, two, three;
            bool bl = Int32.TryParse(str, out one);
            if (bl == true)

            {
                two = one + 1;
                three = one - 1;
                Console.WriteLine($"The next number for the number {one} is {two}." + $"The previous number for the number {one} is {three}.");
            }
            else
            {
                Console.WriteLine("Это не число.");
            }
            Console.ReadKey();
        }
    }
}
