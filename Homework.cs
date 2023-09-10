using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int newInt = 10;
            float newFloat = 8.4f;
            string newStr = "True";
            float bigInt = newInt * 3.5f;
            newFloat = newFloat - 1;
            string bigStr = newStr + "NoNoYesYesYes";
            Console.WriteLine("newInt = " +newInt);
            Console.WriteLine("bigInt = " + bigInt);
            Console.WriteLine("newStr = " + newStr);
            Console.WriteLine("bigStr = " + bigStr);
            Console.WriteLine("newFloat = " + newFloat);
            Console.WriteLine("bigStr = " + bigStr);
            Console.WriteLine("newInt / newFloat = " + newInt / newFloat);
            Console.WriteLine("bigInt / newFloat = " + bigInt / newFloat);
            Console.ReadKey();



        }
    }
}
