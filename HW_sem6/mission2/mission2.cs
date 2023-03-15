
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] peresechenie( double b1, double k1, double b2, double k2){
    double x = 0;    
    double y1 = k1 * x + b1; 
    double y2 = k2 * x + b2;
    double y1OtminusX = -1*k1 * x + b1; 
    double y2OtminusX = -1*k2 * x + b2;
    double [] result  =new double [2];

    while (true){
        y1 =  Math.Round(k1 * x + b1,2);
        y2 =  Math.Round(k2 * x + b2,2);
        if (y1==y2){
            result[0]=x;
            result[1]=y1;
                Console.Write("y="+y1+" ");
                Console.WriteLine("x="+ x);
            return result;
        }

        y1OtminusX = Math.Round(k1 * x *(-1) + b1, 2); 
        y2OtminusX = Math.Round(k2 * x * (-1)  + b2,2);
         
        
        if (y1OtminusX==y2OtminusX){
            result[0]=x;
            result[1]=y2OtminusX;
                Console.Write("y= "+y2OtminusX+" ");
                Console.WriteLine("x="+ x*(-1));
            return result;
            
        }
        x=Math.Round(x+0.01,2);
        

    }
    
}

peresechenie(2, 5, 4, 9);