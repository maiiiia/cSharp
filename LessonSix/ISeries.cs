using System;

//example of interface usage

interface ISeries{
    double GetNext();
    void Reset();
    void SetStart(double x);

}

//6.1
// Используя интерфейс ISeries, создать класс, генерирующий
// последовательный ряд чисел, в котором каждое последующее число на
// два больше предыдущего. Добавить в этот класс метод GetPrevious()

class TwoTimes: ISeries
{
    double[] series;
    int size;
    int current=0;

    public TwoTimes(int n)
    {
        size = n;
        series = new double[n];

    }
    public double GetNext()
    {
        return series[current++];
    }

    public void Reset()
    {
        current = 0;
        
    }

    public void SetStart(double x)
    {
        series[current] = x;
        for (int i=1; i< series.Length; i++)
        {
            series[i] = series[i-1]*2;
        }
        
    }

    public double GetPrevious()
    {
        return series[current--];
    }
}
//6.2
// Используя интерфейс ISeries, реализовать класс, генерирующий ряд
// простых чисел
class PrimeNumbers : ISeries
{
    double[] series;
    int size;
    int current=0;

    public PrimeNumbers(int n)
    {
        size = n;
        series = new double[n];

    }
    public double GetNext()
    {
        return series[current++];
    }

    public void Reset()
    {
        current = 0;
        
    }

    public void SetStart(double x)
    {
        series[current] = x;
        double el = x;
        for (int i=1; i< series.Length; i++)
        {   
            bool flag = true; 
            while(flag)
            {   
                el++;
                for (int j = 2; j<=Math.Sqrt(el); j++)
                {
                    if (el%j == 0) {break;}
                    if (j>Math.Sqrt(el)-1) flag = false;
                }
                
            }
            series[i] = el;
        }
        
    }

    public double GetPrevious()
    {
        return series[current--];
    }
}

