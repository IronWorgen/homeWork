﻿using System;
//    Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//    Массив размером 2 x 2 x 2
//    66(0,0,0) 25(0,1,0)
//    34(1,0,0) 41(1,1,0)
//    27(0,0,1) 90(0,1,1)
//    26(1,0,1) 55(1,1,1)
//    

// создание массива 
int[,,] createArray(int m, int n, int p)
{
    int[,,] array = new int[m, n, p];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Random rand = new Random();
                int nextNumber;
                bool nextItemInMatrix;
                do
                {
                    nextItemInMatrix = false;
                    nextNumber = rand.Next(10, 100);
                    foreach (int item in array)
                    {
                        if (item == nextNumber)
                        {
                            nextItemInMatrix = true;
                            break;
                        }
                    }

                } while (nextItemInMatrix);
                array[i, j, k] = nextNumber;
            }
        }
    }
    return array;
}

//печать массива
void printArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("-------------------------------");
    }
}

int[,,] array = createArray(2, 2, 2);
printArray(array);
