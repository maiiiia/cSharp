using System;

//good examples from lecture 4

// method overload
class Overload
{
    public void OvlDemo()
    {
        Console.WriteLine("Без параметров");
    }
    // Перегрузка метода OvlDemo с одним целочисленным параметром.
    public void OvlDemo(int a)
    {
        Console.WriteLine("Один параметр: " + a);
    }
    // Перегрузка метода OvlDemo с двумя параметрами типа double.
    public double OvlDemo(double a, double b)
    {
        Console.WriteLine("Два параметра типа double: " + a + " " + b);
        return a + b;
    }

    public void MyMeth(int x)
    {
        Console.WriteLine("методе MyMeth(int): " + x);
    }
    public void MyMeth(ref int x)
    {
        Console.WriteLine("методе MyMeth(ref int): " + x);
    }


}

// Продемонстрировать перегрузку конструктора.
class MyClass
{
    public int x;
    public MyClass()
    {
        Console.WriteLine("конструкторе MyClass().");
        x = 0;
    }
    public MyClass(double d)
    {
        Console.WriteLine("конструкторе MyClass(double).");
        x = (int)d;
    }
    public MyClass(int i, int j)
    {
        Console.WriteLine("конструкторе MyClass(int, int).");
        x = i * j;
    }
}

// this keyword

class XYCoord
{
    public int x, y;
    public XYCoord() : this(0, 0)
    {
        Console.WriteLine("В конструкторе XYCoord()");
    }
    public XYCoord(XYCoord obj) : this(obj.x, obj.y)
    {
        Console.WriteLine("В конструкторе XYCoord(obj)");
    }
    public XYCoord(int i, int j)
    {
        Console.WriteLine("В конструкторе XYCoord(int, int)");
        x = i;
        y = j;
    }
}


// static keyword example
class StaticDemo // static = we can use fields of this class without creating an instance of this class
{
    public static int Val = 100;// Переменная типа static.
    public static int ValDiv2() // Метод типа static.
    {
        return Val / 2;
    }
}

// class Program //demonstration of use of static var and method
// {
//     static void Main(string[] args)
//     {
        
//         Console.WriteLine("Исходное значение переменной " +
//         "StaticDemo.Val равно" + StaticDemo.Val);
//         StaticDemo.Val = 8;
//         Console.WriteLine("Текущее значение переменной" +
//         "StaticDemo.Val равно " + StaticDemo.Val);
//         Console.WriteLine("StaticDemo.ValDiv2(): " + StaticDemo.ValDiv2());
//     }
// }

