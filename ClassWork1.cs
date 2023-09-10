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
            char name = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ваш символ: " + name);
            bool isDigit = char.IsDigit(name);
            bool IsWhiteSpace = char.IsWhiteSpace(name);
            bool IsLower = char.IsLower(name);
            bool IsUpper = char.IsUpper(name);
            bool IsPunctuation = char.IsPunctuation(name);
            bool IsControl = char.IsControl(name);
            if (isDigit == true)
            {
                Console.WriteLine("Ваше число попадает в промежуток от 0 до 9");
            }
            if (IsWhiteSpace == true)
            {
                Console.WriteLine("Это символ из категории пробельных");
            }
            if (IsLower == true)
            {
                Console.WriteLine("Это символ из категории букв в нижнем регистре");
            }
            if (IsUpper == true)
            {
                Console.WriteLine("Это символ из категории букв в верхнем регистре");
            }
            if (IsPunctuation)
            {
                Console.WriteLine("Это символ из категории знаков препинания");
            }
            if (IsControl)
            {
                Console.WriteLine("Это символ из категории управляющих символов");
            }


            Console.ReadKey();
        }
    }
}
