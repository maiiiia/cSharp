class TwoDShape
{
    public double Width;
    public double Height;
    public void ShowDim()
    {
        Console.WriteLine("Ширина и высота равны " + Width + " и "
        + Height);
    }
}


class Rectangle : TwoDShape
{
    // Возвратить логическое значение true, если
    // прямоугольник является квадратом.
    public bool IsSquare()
    {
        if (Width == Height) return true;
        return false;
    }
    // Возвратить площадь прямоугольника.
    public double Area()
    {
        return Width * Height;
    }
}

class B
{
    //члены, закрытые для класса В, но доступные для класса D
    protected int i, j;
}
class D : B
{
    int k; //закрытый член
    public void Setk()
    {
        k = i * j; //члены i и j класса В доступны для класса D
    }
    public void Showk()
    {
        Console.WriteLine(k);
    }
}


// Продемонстрировать виртуальный метод.

class Base
{
    // Создать виртуальный метод в базовом классе.
    public virtual void Who()
    {
        Console.WriteLine("Метод Who() в классе Base");
    }
}
class Derivedl : Base
{
    // Переопределить метод Who() в производном классе.
    public override void Who()
    {
        Console.WriteLine("Метод Who() в классе Derivedl");
    }
}




