//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumNum (int num){
    int newNum = num;
    int result = 0;

    if (newNum<0){newNum=-newNum;}

    while ( newNum != 0 ){
        result += newNum%10;
        newNum = newNum/10;
    }
    
    return result;
}

Console.WriteLine(sumNum(-9012));