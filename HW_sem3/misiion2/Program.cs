//Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double getVectorLenght (double x1, double y1, double z1, double x2, double y2, double z2)
{
    //вычисление длины вектора 
    double len = Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2);
    len = Math.Sqrt(len);


    return Math.Round(len,2);
}

Console.WriteLine(getVectorLenght(3, 6, 8, 2, 1, -7));


