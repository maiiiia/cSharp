using System;
class Decompose
{ /* Разделить числовое значение с плавающей точкой на целую и
дробную части. */
    public int GetParts(double n, out double frac)
    {
        frac = n - (int)n;//передать дробную часть числа через параметр frac
        return (int)n; // возвратить целую часть числа
    }
}
class UseOut
{
    static void Main()
    {
        Decompose ob = new Decompose();
        int i;
        double f;
        i = ob.GetParts(10.125, out f);
        Console.WriteLine("Целая часть числа равна " + i);
        Console.WriteLine("Дробная часть числа равна " + f);
    }
}
