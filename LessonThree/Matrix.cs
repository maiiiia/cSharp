using System;

public class Matrix
{
    int n=2;
    int[,] m = new int[2, 2];
    public Matrix()
    {
        //this.n = n;
        //int[,] m = new int[n, n];
        Random rnd = new Random();
        for(int i=0;i<n;i++)
        {
            for (int j=0;j<n;j++)
            {
                m[i,j] = rnd.Next(1, 100);
                Console.WriteLine(m[i,j]);
            } 
        }

    }

    public int det()
    {
        return (m[0,0]*m[1,1] - m[0,1]*m[1,0]); 
    }

}

/* class MatrixDemo
{
    static void Main()
    {
        Matrix test_m = new Matrix();
        Console.WriteLine(test_m.det());
    }
}
*/