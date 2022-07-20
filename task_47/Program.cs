namespace Homework_7
{
    public class task_47
    // Задайте двумерный массив размером m×n,
    // заполненный случайными вещественными числами.
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Задайте колличество строк массива, введите целое число m: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Задайте колличество столбцов массива, введите целое число n: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int rows = m;
                int columns = n;
                int[,] array = new int[rows, columns];
                Fillarray(array);
                PrintArray(array);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз");
            }
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
    }
}
