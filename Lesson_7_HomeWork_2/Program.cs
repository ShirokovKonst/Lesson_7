using System;

namespace Lesson_7_HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Prompt("Введите размерность массива");
            int row = Prompt("Введите номер строки");
            int col = Prompt("Введите номер столбца");
            int[,] mas = GetArray(size);
            Position(mas, row, col, size);
            
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

            void Position(int[,] arr, int r, int c, int s)
            {
                if((r > s) ^ (r <= 0) ^ (c > s) ^ (c <= 0))
                Console.WriteLine("Такого элемента не существует");
                else
                {
                    Console.WriteLine("Значение данного элемента равно: " + arr[r-1,c-1]);
                }
            }
        }
    }
}
