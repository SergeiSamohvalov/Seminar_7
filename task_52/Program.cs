
namespace Homework_7
{
    public class task_52
    // Задайте двумерный массив из целых чисел.
    // Найдите среднее арифметическое элементов в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    {
        static void Main(string[] args)
        {
            int rows = 4;
            int columns = 4;
            int[,] array = new int[rows, columns];
            Fillarray(array);
            PrintArray(array);
            AveragArithmetic(array, rows);

        }
        public static void Fillarray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            return;
        }
        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void AveragArithmetic(int[,] arr, int rows)
        {
            for (int j = 0, k = 0; j < arr.GetLength(1); j++)
            {
                double sum = 0;
                double[] b = new double[rows];

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    sum += arr[i, j];
                }
                b[k] = sum / rows;
                Console.Write((b[k] + " "));
            }
        }
    }
}
