using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан массив из 10 элементов[65, 30, 2, 6, 17, 83, 99, 8, 12, 91], отсортируйте массив в порядке возрастания.
            int[] nums= { 65, 30, 2, 6, 17, 83, 99, 8, 12, 91 };
            Console.WriteLine("Исходный массив:{ 65, 30, 2, 6, 17, 83, 99, 8, 12, 91 }");
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
