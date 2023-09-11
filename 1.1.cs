using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello World");
        int n = 10; //number of years
        float d = 1000; 
        const float p1=1.1f;
        const float p2=1.05f;
        float x=100;
        for (int i = 0; i < n; i++)
        {
            d=p1*d;
            Console.WriteLine ("money left on account after getting '%' from deposit by the end of the year: "+ d);
            d = d - x;
            Console.WriteLine("money left on account after donating to statmod by the end of the year: "+ d);
            x = x*p2;
        }
    }
}