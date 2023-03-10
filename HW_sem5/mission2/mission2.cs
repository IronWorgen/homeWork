//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int sum(int len){
    int sum  =0;
    Random rand = new Random();
    int [] arr = new int[len];

    for (int i = 0; i< len; i++){
        arr [i] = rand.Next(0,10);
        if (i % 2 != 0){sum+=arr[i];}
        
    }

    return sum;
}

Console.Write(sum(5));