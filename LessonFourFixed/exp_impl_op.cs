using System;



public class Pounds
{
    public double Value;

    public Pounds(double value)
    {
        Value = value;
    }

    // Explicit conversion from Pounds to Kilograms
    public static explicit operator Kilograms(Pounds pounds)
    {
        return new Kilograms(pounds.Value * 0.453592);
    }
}

public class Kilograms
{
    public double Value;

    public Kilograms(double value)
    {
        Value = value;
    }
}


public class Inches
{
    public double Value;

    public Inches(double value)
    {
        Value = value;
    }

    // Implicit conversion from Inches to Centimeters
    public static implicit operator Centimeters(Inches inches)
    {
        return new Centimeters(inches.Value * 2.54);
    }
}

public class Centimeters
{
    public double Value;

    public Centimeters(double value)
    {
        Value = value;
    }
}


// class Program
// {
//     static void Main(string[] args)
//     {

//         Inches inches = new Inches(10);
//         Centimeters centimeters = inches; // Implicit conversion
//         Console.WriteLine(centimeters.Value);

//         Pounds pounds = new Pounds(5);
//         Kilograms kilograms = (Kilograms)pounds; // Explicit conversion
//         Console.WriteLine(kilograms.Value);

//     }
// }