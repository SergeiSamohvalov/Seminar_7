namespace Homework_7
{
    public class task_50
    // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 17 -> такого числа в массиве нет
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 4;
            int m = 0;
            int n = 0;
            int[,] array = new int[rows, columns];
            Fillarray(array);
            PrintArray(array);

            try
            {
                Console.Write("Задайте номер строки массива, введите целое число m: ");
                m = Convert.ToInt32(Console.ReadLine());
                if (m < 0) m *= -1;
                Console.Write("Задайте номер столбца массива, введите целое число n: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0) n *= -1;
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз");
            }
            PositionCheck(array, m, n);
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

        public static void PositionCheck(int[,] arr, int m, int n)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == m && j == n)
                    {
                        Console.WriteLine($"Элемент на искомой позиции равен: {arr[i, j]}");

                        return;
                    }
                }
            }
            Console.WriteLine("Такого элемента в массиве нет");
        }
    }
}





