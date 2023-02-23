// максимальное из 3-х чисел
int a = 2, b= 7, c=3;
int max = a; 
if (a > b)
{
    if (a>c){
        Console.WriteLine(a);
    }else {
        Console.WriteLine(c);
    }
}else {
    if (b>c){
        Console.WriteLine(b); 
    }else {
        Console.WriteLine(c);
    }
}

