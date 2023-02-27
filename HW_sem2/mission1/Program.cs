Console.WriteLine("Введите трехзначное число");
string num = Console.ReadLine();

bool triger = true;

while (triger) {

    if (num.Length==3)
    {
        break;
    }

    Console.WriteLine("Введите трехзначное число");
    num = Console.ReadLine();
}

Console.WriteLine(num[1]);