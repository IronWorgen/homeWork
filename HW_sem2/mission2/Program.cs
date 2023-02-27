Console.WriteLine ("введите число");
string num = Console.ReadLine();

if (num.Length==2)
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
    Console.WriteLine(num[2]);
}