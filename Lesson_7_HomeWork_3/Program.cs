using System;

namespace Lesson_7_HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Prompt("Введите размерность массива");
            int[,] mas = GetArray(size);
            Average(mas, size);    
            int Prompt (string msg)
            {
                Console.WriteLine(msg);
                return int.Parse(Console.ReadLine());
            }
            
            int[, ] GetArray(int size)
            {
                int[,] result = new int[size,size];
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        result[i,j] = rnd.Next(-100, 100);
                    }
                }
                return result;
            }

            void Average(int[,] arr, int s)
            {
                double avg = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        avg = avg + arr[i,j];
                    }
                    avg = avg / size;
                    Console.WriteLine("Среднее арифметическое строки " + i + " равно: " + avg);
                    avg = 0;
                }
            }
        }
    }
}
