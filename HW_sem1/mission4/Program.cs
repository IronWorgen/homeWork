int n=0;
bool triger = true;
//проверка введенного числа 
while ( triger ){

    Console.WriteLine("Введите натуральное число > 1");
    n = int.Parse(Console.ReadLine());

    if (n > 1){
        triger = false;
    }
}
 
int counter=2;

while (counter <=n){
    
        if (counter%2==0){
            Console.Write(counter);

            if (counter + 2 <= n ){
                Console.Write(", ");
            }else break;
        }
    counter+=2;
}



