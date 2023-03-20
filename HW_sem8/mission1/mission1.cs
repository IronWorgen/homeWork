// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] createArray(int m, int n)
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



void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] arrayRowSort(int[,] array)
{
    bool isNotSorted;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        isNotSorted = true;
        while (isNotSorted)
        {
            isNotSorted = false;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
                    isNotSorted = true;
                }
            }
        }
    }
    return array;
}

int[,] array = createArray(4, 4);
printArray(array);

Console.WriteLine();
printArray(arrayRowSort(array));

