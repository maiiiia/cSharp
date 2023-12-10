
// Упражнение 8.14
// Написать программу для обработки событий, связанных с нажатием
// клавиш на клавиатуре.

using System;

// Класс аргументов события для передачи информации о нажатой клавише
public class KeyPressedEventArgs : EventArgs
{
    public char KeyPressed { get; }

    public KeyPressedEventArgs(char keyPressed)
    {
        KeyPressed = keyPressed;
    }
}

class Program
{
    // Объявляем событие для нажатия клавиши
    public static event EventHandler<KeyPressedEventArgs> KeyPressed;
    
    // Метод обработки события KeyPressed
    private static void Program_KeyPressed(object sender, KeyPressedEventArgs e)
    {
        Console.WriteLine($"You pressed: {e.KeyPressed}");
    }

    // Метод для вызова события KeyPressed
    protected static void OnKeyPressed(KeyPressedEventArgs e)
    {
        KeyPressed?.Invoke(null, e);
    }

    static void Main()
    {
        Console.WriteLine("Press any key. Press 'Q' to quit.");

        KeyPressed += Program_KeyPressed;

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            // Вызываем событие при нажатии клавиши
            OnKeyPressed(new KeyPressedEventArgs(keyInfo.KeyChar));

            if (keyInfo.Key == ConsoleKey.Q)
            {
                Console.WriteLine("Quitting the application.");
                break;
            }
        }
    }


}



