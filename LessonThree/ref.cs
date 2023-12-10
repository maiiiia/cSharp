// Использовать модификатор ref для
// передачи значения обычного типа по ссылке.
using System;
class RefTest
{
    // Этот метод изменяет свой аргумент. Обратите
    // внимание на применение модификатора ref.
    public static void Sqr(ref int i)
    {
        i *= i;
    }
}
class RefDemo
{
    static void Main()
    {
        RefTest ob = new();
        int a = 10;
        Console.WriteLine("a до вызова: " + a);
        RefTest.Sqr(ref a); // обратите внимание на применение модификатора ref
        Console.WriteLine("a после вызова: " + a);
    }
}
// Результат:
// а до вызова: 10
// а после вызова: 100


