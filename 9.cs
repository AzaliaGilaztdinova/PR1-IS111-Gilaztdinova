using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тип показа Премьера, Обычный, Льготный");
            string Tip=Console.ReadLine();
            Console.WriteLine("введите кол-во строк");
            int R = int.Parse(Console.ReadLine());
            Console.WriteLine("введите кол-во столбцов");
            int C = int.Parse(Console.ReadLine());
            int M = R * C;
            int T = 0;
            switch (Tip)
            {
                case "Премьера":
                    T = M * 600;
                    break;
                case "Обычный":
                    T = M * 410;
                    break;
                case "Льготный":
                    T = M * 250;
                    break;
                default:
                    Console.WriteLine("Ошибка,некорректный тип показа");
                    return;
            }
            Console.WriteLine("общий доход :" + T + "руб");


        }
    }
}
