using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        { //Пользователь вводит целое число N. Выведите на консоль все числа от 1 до N включительно, используя цикл for.

            int a =int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
                Console.WriteLine();
        }
    }
}
