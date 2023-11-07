using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        { //Напишите программу которая принимает 2 числа n и l и генерирует все возможные пятизначные пароли по требованиям:
//символ 1: число в промежутке от 1 до n.
//символ 2: число в промежутке от 1 до n.
//символ 3: маленькая буква среди первых l букв английского алфавита. (если l = 4, то возможные буквы - a,b,c,d)
//символ 4: маленькая буква среди первых l букв английского алфавита.
//символ 5:больше чем первые два числа
            int n, l;
            Console.WriteLine("Введите число n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число l");
            l = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        for (int m = 0; m < l; m++)
                        {
                            for (int o = Math.Max(i, j) + 1; o <= 9; o++)
                            {
                                Console.WriteLine($"{i}{j}{(char)('a' + k)}{(char)('a' + m)}{o}");
                            }
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
