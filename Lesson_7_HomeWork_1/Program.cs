using System;
using System.Globalization;

namespace Lesson_7_HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int rows = Prompt("Введите кол-во строк");
            int cols = Prompt("Введите кол-во столбцов");
            double minVal = PromptMaxMin("Введите минимальное значение");
            double maxVal = PromptMaxMin("Введите максимальное значение");
            int acc = Prompt("Введите точность результата");
            double[,] result = GetArray(rows, cols, minVal, maxVal, acc);
            PrintArray(result, rows, cols);
        
            int Prompt (string msg)
            {
                Console.WriteLine(msg);
                return int.Parse(Console.ReadLine());
            }

            double PromptMaxMin (string msg)
            {
                Console.WriteLine(msg);
                return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double[,] GetArray (int m, int n, double min, double max, int accuracy)
            {
                double[,] mas = new double[m,n];
                Random x = new Random();
                for(int i = 0; i < m; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        mas [i,j] =Math.Round((min + x.NextDouble() * (max + min*(-1))), accuracy);
                    }
                }  
                return mas;  
            }

            void PrintArray (double[,] mas, int m, int n)
            {
                for(int i = 0; i < m; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        Console.Write(mas[i,j]+ " ");
                    }
                    Console.Write('\n');
                }    
            }
        }
    }
}
