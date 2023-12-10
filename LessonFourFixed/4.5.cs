using System;

// Упражнение 4.5
// Реализовать статический класс MyMath с методами отсутствующими в
// классе Math. Например, добавить возможность вычисления определенного
// интеграла, округления вверх и т.п. (3-4 метода)

static class MyMath
{
    public static int ceil(double num)
    {
        int result = (int)num + 1;
        return result;
    }
    public static double simpsonIntegral(double a, double b, double[] f_val)
    {
        double integral = (b-a)/6;
        integral *= (f_val[0] + 4*f_val[1] + f_val[2]);
        return integral;
    }
}

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(MyMath.ceil(4.33));
//         double[] f_values = new double[3]{0,-0.25,-1};
//         Console.WriteLine(MyMath.simpsonIntegral(0, 1, f_values));
//     }
// }