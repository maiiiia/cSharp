using System;

// Упражнение 6.6
// Придумать и реализовать пример обоснованного использования структуры
// (вместо класса).

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method to calculate distance from the origin
    public double CalculateDistance()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

//WHY USE GET - SET?
// this code:

// public int X { get; set; }

//is equivalent to:

// private int _x;
// public int X
// {
//     get { return _x; }
//     set { _x = value; }
// }


// class Program
// {
//     static void Main()
//     {
//         // Creating instances of the Point struct
//         Point point1 = new Point(3, 4);
//         Point point2 = new Point(-2, 1);

//         // Accessing properties
//         Console.WriteLine($"Point 1: X = {point1.X}, Y = {point1.Y}");
//         Console.WriteLine($"Point 2: X = {point2.X}, Y = {point2.Y}");

//         // Using the CalculateDistance method
//         Console.WriteLine($"Distance from Point 1 to the origin: {point1.CalculateDistance()}");
//         Console.WriteLine($"Distance from Point 2 to the origin: {point2.CalculateDistance()}");
//     }
// }
