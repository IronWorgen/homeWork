//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int sumEven(int len){
    int counter  =0;
    Random rand = new Random();
    int [] arr = new int[len];

    for (int i = 0; i < len; i++){
        arr[i] = rand.Next(100,1000);
        if (arr[i]%2==0){ counter ++; }
        
    }

    return counter;

}

Console.WriteLine(sumEven(10));

