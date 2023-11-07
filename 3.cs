using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выведите числа 1... n в виде пирамиды, как в примерах ниже.В первой строке мы печатаем одно число,
            // во второй строке мы печатаем два числа, в третьей строке мы печатаем три числа и так далее,
            // пока числа не закончатся.В последней строке мы печатаем столько чисел, сколько у нас получится, пока не дойдем до n.
            int a;
            Console.Write("Введите число a: ");
            a = int.Parse(Console.ReadLine());
            int b = 1;
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(b++ + " ");

                    if (b > a)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (b > a)
                {
                    break;
                }
            }
            Console.ReadLine();

        }
            }
}
