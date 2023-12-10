using System;

//example of interface inheritance
public interface IA
{
    void Meth1();
}
//В базовый интерфейс включен метод Meth1().
//а в производный интерфейс добавлен еще один метод Meth2().
public interface IB : IA
{
    void Meth2();
}
//В этом классе должны быть реализованы методы интерфейсов IA и IB.
class MyClass1 : IB
{
    public void Meth1()
    {
        Console.WriteLine("Реализовать метод Meth1().");
    }
    public void Meth2()
    {
        Console.WriteLine("Реализовать метод Meth2().");
    }
}


//явная реализация интерфейса
interface IMyIF
{
    int MyMeth(int x);
}
class MyClass2 : IMyIF
{
    int IMyIF.MyMeth(int x) //явная реализация члена интерфейса
    {
        return x / 3;
    }
    public int MyMethI(int x)
    {
        IMyIF a_ob;
        a_ob = this;
        return a_ob.MyMeth(x); // вызов интерфейсного метода IMyIF
    }
}

