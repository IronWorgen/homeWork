Console.WriteLine ("введите число:");
int num = int.Parse(Console.ReadLine());

if (num == 7 | num == 6 )
{
    Console.WriteLine ("да");
}
else
{
    if ( num < 6 & num > 0)
    {
        Console.WriteLine ("нет ");
    }
    else
    {
        Console.WriteLine ("нет такого дня недели");
    }
}


