
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 
// Например, задан массив:
// 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// 

int[,] createArray(int m)
{
    int[,] arr = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
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

int GetIndexRowWithMinSum(int[,] array)
{
    int indexRowWithMinSum = 0;
    int MinSum = 0;
    int temporalSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) { MinSum += array[i, j]; }
            temporalSum += array[i, j];

        }

        if (MinSum > temporalSum)
        {
            MinSum = temporalSum;
            indexRowWithMinSum = i;
        }
        temporalSum = 0;
    }
    return indexRowWithMinSum;
}

int[,] array = createArray(3);
printArray(array);

Console.WriteLine();
Console.WriteLine(GetIndexRowWithMinSum(array));



