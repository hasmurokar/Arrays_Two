using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            var array = new int[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Число: {i + 1} : {j + 1}");
                    array[i, j] = rnd.Next(10, 50);
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
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        array[i, j] = 0;
                        break;
                    }
                }
            }

            Console.WriteLine("Массив после");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
