using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Число: {i + 1} : {j + 1}");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();

            Console.WriteLine("Массив до");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                var flag = true;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[j, i] == 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.WriteLine($"В {i + 1} столбце отсутствуют нулевые элементы");
                }
                
            }


            Console.ReadLine();
        }
    }
}
