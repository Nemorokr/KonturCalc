using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double x1;
                double x2;
                double answ;
                string action;

                Console.WriteLine("Введите первое число: ");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите действие: ");
                action = Console.ReadLine();
                Console.WriteLine("Введите второе число: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                if (action == "+")
                {
                    answ = x1 + x2;
                    Console.WriteLine("Ответ: " + answ);
                }
                else if (action == "-")
                {
                    answ = x1 - x2;
                    Console.WriteLine("Ответ: " + answ);
                }
                else if (action == "*")
                {
                    answ = x1 * x2;
                    Console.WriteLine("Ответ: " + answ);
                }
                else if (action == "/")
                {
                    answ = x1 / x2;
                    Console.WriteLine("Ответ: " + answ);
                }
                else
                    Console.WriteLine("Неверный оператор");
            }
        }
    }
}
