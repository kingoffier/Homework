using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string big = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введенная строка - " +big);
            char a;
            bool b = Char.TryParse(big, out a);
            if (b == true)
            {
                Console.WriteLine($"Ваша строка является символом");

            }
            int aa;
            bool bb = Int32.TryParse(big, out aa);
            if (bb == true) {

                Console.WriteLine($"В вашей строке есть целое число") ;
            
            }
            double aaa;
            bool bbb = Double.TryParse(big, out aaa);
            if (bbb == true)
            {
                Console.WriteLine($"В вашей строке есть дробное число");
            }
            bool aaaa;
            bool bbbb = Boolean.TryParse(big, out aaaa);
            if(bbbb == true)
            {
                Console.WriteLine("Есть логическое значение");
            }
            Console.ReadKey();
        }
    }
}
