//Напишите программу, которая задаёт массив и выводит его на экран.

int[] arrPrint (int len){

    int[] arr =  new int[len];
    Random rand = new Random();

    for( int i =0 ; i < arr.Length; i++){
        arr[i]= rand.Next(0,100);
        //для пследнего элемента не печатаем запятую
        if (i == arr.Length-1){
            Console.Write(arr[i]);
            break;
            }
        Console.Write(arr[i]+", ");
    }
    return arr;
}

arrPrint(10);