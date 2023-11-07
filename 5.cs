using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        { //Дана дата из трех чисел (день, месяц и год). Вывести «the date is correct«,
          //если такая дата существует иначе вывести «the date is incorrect«. Считать, что в феврале всегда 28 дней.int a, b, c;
            int a, b, c;
            Console.WriteLine("Введите день a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год c: ");
            c = int.Parse(Console.ReadLine());
            if (b == 1 || b == 3 || b == 5 || b == 7 || b == 8 || b == 10 || b == 12)
            {
                if (a <= 31)
                {
                    Console.WriteLine("The date is correct");
                }
            }
            else { Console.WriteLine("The date is incorrect"); }
            if (b == 11 || b == 4 || b == 6 || b == 9 || b == 10)
            {
                if (a <= 30)
                {
                    if (b == 2)
                    {
                        if (a <= 28)
                        {
                            Console.WriteLine("The date is correct");
                        }
                    }
                }
            }
        }
    } }
