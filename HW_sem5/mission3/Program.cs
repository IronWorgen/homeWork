//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double maxMinusMin(int len){
    Random rand = new Random();
    double [] arr = new double[len];
    double maxNum=0;
    double minNum=0;

    for ( int i = 0; i < len; i++){
        arr[i] = rand.Next(-10,10)+ Math.Round(rand.NextDouble(),2);
        if (arr[i]<minNum){minNum = arr[i];}
        if (arr[i]>maxNum){maxNum = arr[i];}
        
    }
    return Math.Round(maxNum - minNum,2);

}

Console.WriteLine(maxMinusMin(5));