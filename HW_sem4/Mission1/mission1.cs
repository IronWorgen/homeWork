//Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int aPowB (int a, int b ){
    int result =a;    
    if (b == 1) return a;
    if (b == 0) return 1;
    for (int i =2; i <= b; i++){
        result *=a ;
    }
    return result;
}


Console.WriteLine(aPowB (3,1));