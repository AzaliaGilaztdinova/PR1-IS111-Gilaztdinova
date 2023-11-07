using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу которая будет выводить пирамиду из чисел, увеличивающихся на 1.

            int k = 1; int a;
            Console.Write("Введите кол-во строк: ");
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write(k+++ " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
