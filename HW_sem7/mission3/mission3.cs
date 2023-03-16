//   Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  
//  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//  

int[,] randomArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            arr[i, j] = rand.Next(0, 10);
        }
    }
    return arr;

}

void printArray(int[,] arr)
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

double[] averageInСolumn(int[,] arr)
{
    double[] results = new double[arr.GetLength(1)];
    double average = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            average += Convert.ToDouble(arr[j, i]);
        }
        results[i] = Math.Round(average / arr.GetLength(0), 2);
        average = 0;
    }
    return results;
}

int[,] arr = randomArray(1, 1);
printArray(arr);
Console.WriteLine();

double[] average = averageInСolumn(arr);

for (int i = 0; i < average.Length; i++)
{
    Console.Write(average[i] + " ");
}