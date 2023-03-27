//   Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//  или же указание, что такого элемента нет.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  
//  17 -> такого числа в массиве нет
//  

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

int[,] randomArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            arr[i, j] = rand.Next(0, 15);
        }
    }
    return arr;

}

void arrayItem(int m, int n, int[,] arr)
{
    if (m > arr.GetLength(0) | n > arr.GetLength(1)) { Console.WriteLine($"нет элемента с индексом [{m},{n}]"); }
    Console.WriteLine(arr[m, n]);
}


int[,] arr = randomArray(5, 5);
printArray(arr);

Console.WriteLine();
arrayItem(2, 3, arr);
// text box label fiel