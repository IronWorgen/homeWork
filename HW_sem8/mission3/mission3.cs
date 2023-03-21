
using System;
//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//  Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
//  Результирующая матрица будет:
//  18 20
//  15 18

// создание массива 
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

// печать массива 
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

//проверка. Можно ли умножить матрицы  
bool canMultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0)) { return true; }
    return false;
}

// умножение матриц 
int[,] multiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int resultMultiplyOnPosition = 0;
    int[,] resutMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < resutMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resutMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMultiplyOnPosition += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resutMatrix[i, j] = resultMultiplyOnPosition;
            resultMultiplyOnPosition = 0;
        }
    }
    return resutMatrix;
}

int[,] array1 = createArray(4, 2);
int[,] array2 = createArray(5, 3);

Console.WriteLine("Матрица 1 ");
printArray(array1);
Console.WriteLine("Матрица 2 ");
printArray(array2);

if (canMultiplyMatrix(array1, array2))
{
    Console.WriteLine("Результат");
    printArray(multiplyMatrix(array1, array2));
}
else Console.WriteLine("Невозможно перемножть эти матрицы");


