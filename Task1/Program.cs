using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var countNoEven = 0;

            var array = new int[3,3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Число: {i + 1} : {j + 1}" );
                    array[i, j] = int.Parse(Console.ReadLine());
                    if (array[i, j] % 2 == 1)
                    {
                        countNoEven++;
                    }
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

            Console.WriteLine($"Нечетных: {countNoEven}");


            for (int i = 0; i < array.GetLength(0); i++)
            {
                var sumPositive = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] > 0)
                    {
                        sumPositive += array[i, j];
                    }
                }
                Console.WriteLine($"Сумма положительных в {i + 1} ряду = {sumPositive}");
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                var sumPositive = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[j, i] > 0)
                    {
                        sumPositive += array[j, i];
                    }
                }
                Console.WriteLine($"Сумма положительных в {i + 1} столбце = {sumPositive}");
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
 
                    if (array[i, j] % 2 == 0)
                    {
                        array[i, j] += 1;
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
