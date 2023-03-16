//    Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//   m = 3, n = 4.
//   0,5 7 -2 -0,2
//   1 -3,3 8 -9,9
//   8 7,8 -7,1 9
//   

void printArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

double[,] randomArray(int m, int n)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            arr[i, j] = Math.Round(rand.NextDouble() * 100, 1);
        }
    }
    return arr;

}

printArray(randomArray(4, 4));