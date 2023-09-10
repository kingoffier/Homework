using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет создатель,как тебя зовут?");
            string answeruser = Console.ReadLine();
            Console.WriteLine("А как ты назовешь меня?");
            string namebot = Console.ReadLine();
            Console.WriteLine($"Приятно познакомимся {answeruser}.Меня зовут {namebot} - это ты меня назвал");
            Console.ReadKey();
        }
    }
}
