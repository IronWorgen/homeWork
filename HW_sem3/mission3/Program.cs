//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void getCubeTable (int number)
{
    for (int i = 1; i <= number; i ++){
        if (i == number) 
        {
            Console.WriteLine(Math.Pow(i,3)+".");
            break;

        }
        Console.Write(Math.Pow(i,3)+", ");
    }
}

getCubeTable (5);
