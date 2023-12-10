

using System;

class Destruct
{
    public int x;
    public Destruct(int i)
    {
        x = i;
    }
    ~Destruct()
    {
        Console.WriteLine("destroy "+ x);
    }

    public void Generator(int i)
    {
        Destruct dest = new Destruct(i);
    }
}

/*
class DestructDemo
{
    static void Main()
    {
        int count;
        Destruct ob = new Destruct(0);
        for (count = 1; count < 20; count++)
        {ob.Generator(count);}
        Console.WriteLine("Готово!");
    }
}
*/