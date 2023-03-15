int countMoreNull(int m){
    int counter =0;
    for ( int i = 0 ; i <= m; i ++){
        Console.Write("Введите число №"+ i + ": ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0){
            counter++;
        }
        Console.WriteLine();
    }
    return counter;
}

Console.Write(countMoreNull(5));