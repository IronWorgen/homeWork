// максимальное из 3-х чисел

Console.WriteLine("Введите чило №1");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите чило №2");
int number2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите чило №3");
int number3 = Convert.ToInt32 (Console.ReadLine());

int max = number1;

if (number2>max) max = number2;
if (number3>max) max = number3;

Console.WriteLine(max);

