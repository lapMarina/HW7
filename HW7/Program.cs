using System;

namespace HW7
{
    class Program
    {
        static double[,] GetMatrix(int rows, int columns)
        {
            var random = new Random();
            var twoDimensionalArray = new double[rows, columns];
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i, j] = Math.Round(random.NextDouble() * 10, 1);
                    Console.Write($"{twoDimensionalArray[i, j]} ");
                }
                Console.WriteLine();
            }
                
            return twoDimensionalArray;

        }

        static int[,] GetIntMatrix(int rows, int columns)
        {
            var random = new Random();
            var twoDimensionalArray = new int[rows, columns];
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i, j] = random.Next(0, 10);
                    Console.Write($"{twoDimensionalArray[i, j]} ");
                }
                Console.WriteLine();
            }

            return twoDimensionalArray;

        }

        static void CheckElement(int row, int column) 
        {
            var matrix = GetMatrix(3, 4);
            if (matrix.GetLength(0) < row || matrix.GetLength(1) < column)
                Console.WriteLine($"Элемента [{row}, {column}] в массиве нет");
            else
                Console.WriteLine(matrix[row - 1, column - 1]);
        }


        static void FirstTask() 
        {
            GetMatrix(3, 4);
        }

        static void SecondTask()
        {
            Console.WriteLine("Введите номер строки");
            var row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер столбца");
            var conlumn = int.Parse(Console.ReadLine());
            CheckElement(row, conlumn);
        }

        static void ThirdTask()
        {
            var array = GetIntMatrix(3, 4);
            for (var i = 0; i < array.GetLength(0); i++) 
            {
                var sum = 0;
                for (var j = 0; j < array.GetLength(1); j++) 
                {
                    sum += array[i, j];
                }
                var result = (double)sum / array.GetLength(1);
                Console.Write($"{result} ");
            }
        }

        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
        }
    }
}
