// Упражнение 4.8
// Реализовать перегруженный бинарный оператор "+" для сдвига заданного
// вектора из пространства R3 покоординатно на целое число.


using System;

class Vector
{
    public double x, y, z;
    public Vector(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Vector operator +(Vector v, int num)
    {
        Vector result = new Vector(v.x + num, v.y + num, v.z + num);
        return result;
    }
}



// class Program
// {
//     static void Main(string[] args)
//     {
//         Vector v = new Vector(0.5, 1.5, 2.5);
//         Console.WriteLine(v);
//         Vector new_v = v+3;
//         Console.WriteLine(new_v.x);
//     }
// }