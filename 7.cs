
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
//Напишите программу, которая выводит в консоль все числа от N до M, которые делятся на 2 и 3 без остатка,
//в обратном порядке. S - число остановки.Если какое-либо из чисел, кратных 2 и 3, равно числу остановки,
//оно не должно быть напечатано, и программа должна завершиться. В противном случае выведите все числа до N,
//которые удовлетворяют условию.
//Input: ввод 3 чисел на отдельных строках /N –целое число: 0 ≤ N < M.  /M – целое число: N < M ≤ 10000.
//S – целое числоr: N ≤ S ≤ M.
                int a, b, s;
                Console.WriteLine("Введиет число a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введиет число b");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введиет число остановки");
                s = int.Parse(Console.ReadLine());
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        if (i == s) { Console.WriteLine("Программа приостановлена"); break; }
                        else { Console.WriteLine("Ответ:" + i); }
                    }

                }
            }
        }
    }
}
