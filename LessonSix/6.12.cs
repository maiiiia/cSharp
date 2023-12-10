using System;


// 6.12
// Реализовать класс для создания массива, индексируемого в пределах от
// -10 до 10. Добавить свое исключение для обработки ошибок при
// обращении к массиву вне допустимого диапазона


using System;

public class MyArray
{
    private int[] array;

    public MyArray()
    {
        // Initialize the array with a range from -10 to 10
        array = new int[21];
        for (int i = -10; i <= 10; i++)
        {
            array[i + 10] = i;
        }
    }

    public int this[int index]
    {
        get
        {
            ValidateIndex(index);
            return array[index + 10];
        }
        
        set
        {
            ValidateIndex(index);
            array[index + 10] = value;
        }
    }

    private void ValidateIndex(int index)
    {
        if (index < -10 || index > 10)
        {
            throw new MyArrayIndexOutOfRangeException("Index is out of range.");
        }
    }
}

public class MyArrayIndexOutOfRangeException : Exception
{
    public MyArrayIndexOutOfRangeException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        MyArray myArray = new MyArray();

        try
        {
            Console.WriteLine(myArray[5]); // Accessing a valid index
            Console.WriteLine(myArray[-15]); // Accessing an invalid index
        }
        catch (MyArrayIndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Output:
        // 5
        // Error: Index is out of range.
    }
}

