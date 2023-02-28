//решение через строки 

//Console.WriteLine ("введите число");
//string num = Console.ReadLine();
//
//if (num.Length==2)
//{
//    Console.WriteLine("третьей цифры нет");
//}
//else 
//{
//    Console.WriteLine(num[2]);
//}

//решение без использования строк

Console.WriteLine ("введите число");
int num = int.Parse(Console.ReadLine());
int pos_3=0;
int counter = 0;
int delitel = 10;
//нахожу длуну числа 
while (num / delitel != 0) 
{
    counter ++;
    delitel *=10;
}

if (counter < 2) 
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    pos_3 = num / (delitel/1000);
    pos_3 = pos_3 % 10;
    Console.WriteLine (pos_3);
    
}



