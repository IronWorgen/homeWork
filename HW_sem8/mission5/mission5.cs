//  Напишите программу, которая заполнит спирально массив 4 на 4.
//  Например, на выходе получается вот такой массив:
//  01 02 03 04
//  12 13 14 05
//  11 16 15 06
//  10 09 08 07


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

int[,] spiralArray(int size)
{
    int[,] array = new int[size, size];
    int item = 1;
    for (int padding = 0; padding <= size / 2; padding++)
    {
        for (int i = padding; i < size - padding; i++)
        {
            array[padding, i] = item;
            item++;
        }
        for (int i = padding + 1; i < size - padding; i++)
        {
            array[i, size - padding - 1] = item;
            item++;
        }
        for (int i = size - padding - 2; i >= padding; i--)
        {
            array[size - padding - 1, i] = item;
            item++;
        }
        for (int i = size - padding - 2; i >= padding + 1; i--)
        {
            array[i, padding] = item;
            item++;
        }

    }
    return array;
}

printArray(spiralArray(5));
